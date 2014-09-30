import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseMotionListener;
import java.net.URL;
import java.util.Random;

import javax.swing.ImageIcon;
import javax.swing.JComponent;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.Timer;
import javax.swing.WindowConstants;

public class Mandalore extends JComponent implements ActionListener,
		KeyListener, MouseMotionListener {

	private static final long serialVersionUID = 1L;
	private static JFrame window = new JFrame("Apple Fall");
	private static int width = 800;
	private static int height = 660;
	private static Image backImg;
	private static Image basketImg;
	private static Image appleImg;
	private static int basketPos;
	private static int appleY;
	private static int appleX;
	private static int dX; // for basket horizontal speed
	private static int dY; // for apple falling speed
	private static int tick;
	private static int ticks; // all ticks
	private static Random rnd;
	private static int catchedApples;
	private static int lostApples;
	private static Font font;
	
	public static String NAME = "Sound";
	public static boolean leftPressed = false;
	public static boolean rightPressed = false;

	private static void init() {
		rnd = new Random();
		dX = 8;
		dY = 1;
		tick = 0;
		ticks = 0;
		catchedApples = 0;
		lostApples = 20;
		basketPos = 350;
		appleX = rnd.nextInt(700) + 50;
		appleY = rnd.nextInt(100) + 50;
		font = new Font("Times", Font.BOLD, 20);
		spd = 50;
		
	}
	
	public static void main(String[] args) {
		init();
		window.setPreferredSize(new Dimension(width, height));
		window.setResizable(false);
		window.pack();
		Mandalore game = new Mandalore();
		URL tempURL = Mandalore.class.getResource("/background2.png");
		backImg = new ImageIcon(tempURL).getImage();
		tempURL = Mandalore.class.getResource("/appleBasket.png");
		basketImg = new ImageIcon(tempURL).getImage();
		tempURL = Mandalore.class.getResource("/apple.png");
		appleImg = new ImageIcon(tempURL).getImage();
		window.add(game);
		Sound.music.play();
		window.setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
		window.setLocationRelativeTo(null);
		window.setVisible(true);

		Timer t = new Timer(10, game);
		t.start();
		window.addMouseMotionListener(game);
		window.addKeyListener(game);

		
	}

	private static int spd; // acceleration

	@Override
	protected void paintComponent(Graphics g) {

		// background
		g.drawImage(backImg, 0, 0, null);
		// apples
		drawApple(g);
		// basket
		g.drawImage(basketImg, basketPos, height - basketImg.getHeight(this)
				- 25, null);
		g.setColor(Color.orange);
		g.setFont(font);
		g.drawString("Catched " + catchedApples, 680, 35);
		g.drawString("Lost  " + lostApples, 710, 60);

	}

	private void drawApple(Graphics g) {
		g.drawImage(appleImg, appleX, appleY, null);
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		tick++;
		ticks++;
		if (appleY < height - 90) {
			appleY += dY;
		} else {
			if (appleX > basketPos
					&& appleX < basketPos + basketImg.getWidth(null)) {
				catchedApples++;
				Sound.sound1.play();

			} else {
				lostApples--;
				Sound.sound2.play();
			}
			dY = 1;
			appleX = rnd.nextInt(700) + 50;
			appleY = rnd.nextInt(300) + 50;

		}
		if (tick >= spd) {
			tick = 0;
			dY++;
		}
		if (ticks % 200 == 0 && spd > 2) {
			if (dX < 0)
				dX -= 1;
			else
				dX += 0.5;
			spd--;
		}

		if (basketPos < 0 - basketImg.getWidth(null) / 2) {
			basketPos = 5 - basketImg.getWidth(null) / 2;
		}
		if (basketPos > width - basketImg.getWidth(null) / 2) {
			basketPos = width - 5 - basketImg.getWidth(null) / 2;
		}

		if (Mandalore.leftPressed || Mandalore.rightPressed)
			basketPos += dX;
		repaint();
		gameOver();
	}

	private void gameOver() {
		if (lostApples == 0) {
			int dialogResult = JOptionPane.showConfirmDialog(null, "Game over. Try Again?", "Game over", JOptionPane.YES_NO_OPTION);
			if (dialogResult == JOptionPane.YES_OPTION) {
				init();
			}
			else {
				window.dispose();
				System.exit(0);
			}
		}
	}

	@Override
	public void mouseDragged(MouseEvent e) {

	}

	@Override
	public void mouseMoved(MouseEvent e) {

	}

	@Override
	public void keyPressed(KeyEvent e) {
		int key = e.getKeyCode();
		if (key == KeyEvent.VK_LEFT) {
			leftPressed = true;
			dX = -Math.abs(dX);
		}
		if (key == KeyEvent.VK_RIGHT) {
			rightPressed = true;
			dX = Math.abs(dX);
		}
	}

	@Override
	public void keyReleased(KeyEvent e) {
		int key = e.getKeyCode();
		if (key == KeyEvent.VK_LEFT) {
			leftPressed = false;
		}

		if (key == KeyEvent.VK_RIGHT) {
			rightPressed = false;
		}

	}

	@Override
	public void keyTyped(KeyEvent e) {
	}

}
