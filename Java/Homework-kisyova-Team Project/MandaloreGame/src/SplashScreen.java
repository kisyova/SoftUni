import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.Insets;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.net.URL;

import javax.swing.Box;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.SwingUtilities;

@SuppressWarnings("serial")
public class SplashScreen extends JPanel {

	private static Image backImg;
	private static JFrame frame;

	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {
				createAndShowGui();
			}
		});
	}

	public SplashScreen() {
		JButton jbt1 = new JButton();
		URL tempURL = Mandalore.class.getResource("/button.png");
		ImageIcon btn_normal = new ImageIcon(tempURL);
		tempURL = Mandalore.class.getResource("/button_over.png");
		ImageIcon btn_hover = new ImageIcon(tempURL);
		jbt1.setBorderPainted(false);
		jbt1.setBorder(null);
		jbt1.setMargin(new Insets(0, 0, 0, 0));
		jbt1.setContentAreaFilled(false);
		jbt1.setIcon(btn_normal);
		jbt1.setRolloverIcon(btn_hover);
		
		Box box = Box.createVerticalBox();
		box.add(Box.createVerticalStrut(320));
		box.add(Box.createHorizontalStrut(80));
		box.add(jbt1);
		add(box);
		tempURL = Mandalore.class.getResource("/background.png");
		backImg = new ImageIcon(tempURL).getImage();

		jbt1.addActionListener(new ActionListener(){

		    public void actionPerformed(ActionEvent e)
		    {
		        //Do something!
		        new Mandalore();
		        String[] args = {};
		        Mandalore.main(args);
//		        removeAll();
//		        revalidate();
//		        repaint();
		    }
		});
	}
	
	

	@Override
	protected void paintComponent(Graphics g) {

		// background
		g.drawImage(backImg, 0, 0, null);

	}

	public static void createAndShowGui() {

	    frame = new JFrame();

	    frame.add(new SplashScreen());

	    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	    frame.setPreferredSize(new Dimension(800, 660));
	    frame.pack();
	    frame.setLocationRelativeTo(null);;
	    

	    frame.setVisible(true);

	   }
}