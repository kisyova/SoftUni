import java.applet.Applet;
import java.applet.AudioClip;


public class Sound {
	//URL tempURL = Mandalore.class.getResource("/background2.png");
	public static final Sound sound1 = new Sound("/basket.wav");
	public static final Sound sound2 = new Sound("/grass.wav");
	public static final Sound music = new Sound("/Background_Music.wav");
	
	private AudioClip clip;
	
	public Sound (String filename) {	
		try {
			clip = Applet.newAudioClip(Sound.class.getResource(filename));			
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
	
	public void play(){
		try {
			new Thread(){
				public void run(){
					clip.play(); 
				}
			}.start();
		} catch (Exception ex) {
			ex.printStackTrace();
		}
	}

	public void loop() {
		// TODO Auto-generated method stub
		
	}
}
