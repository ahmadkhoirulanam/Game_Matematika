using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LatihanApplication : MonoBehaviour
{
     public void menu_utama () {
        
		SceneManager.LoadScene("main");
     }
	 
	  public void profikl () {
        
		SceneManager.LoadScene("tutorial");
     }
     public void menu_kuis () {
        
		SceneManager.LoadScene("menu_kuis");
     }


    public void profil()
    {

        SceneManager.LoadScene("kreator");
    }

    public void Kembali () {
        
		SceneManager.LoadScene("main");
     }
	public void belajar () {
        
		SceneManager.LoadScene("belajar");
		
     }
     public void kuis_1 () {
        
		SceneManager.LoadScene("kuis_1");
		
     }
     public void kuis_2 () {
        
		SceneManager.LoadScene("kuis_2");
		
     }
     public void kuis_3 () {
        
		SceneManager.LoadScene("kuis_3");
		
     }
    public void kuis1_banding () {
        
		SceneManager.LoadScene("soal_1_banding");
		
     }

     public void kuis1_campuran () {
        
		SceneManager.LoadScene("soal_1_campuran");
		
     }
     public void kuis1_penjumlahan () {
        
		SceneManager.LoadScene("soal_1_penjumlhan");
		
     }

    public void kuis1_urut () {
        
		SceneManager.LoadScene("soal_1_urut");
		
     }

     public void kuis2_banding () {
        
		SceneManager.LoadScene("soal_2_banding");
		
     }

     public void kuis2_campuran () {
        
		SceneManager.LoadScene("soal_2_campuran");
		
     }
     public void kuis2_penjumlahan () {
        
		SceneManager.LoadScene("soal_2_penjumlhan");
		
     }

    public void kuis2_urut () {
        
		SceneManager.LoadScene("soal_2_urut");
		
     }

     public void kuis3_banding () {
        
		SceneManager.LoadScene("soal_3_banding");
		
     }

     public void kuis3_campuran () {
        
		SceneManager.LoadScene("soal_3_campuran");
		
     }
     public void kuis3_penjumlahan () {
        
		SceneManager.LoadScene("soal_3_penjumlhan");
		
     }

    public void kuis3_urut () {
        
		SceneManager.LoadScene("soal_3_urut");
		
     }

    public void cacah1 () {
        
		SceneManager.LoadScene("cacah1");
		
     }
      public void cacah2 () {
        
		SceneManager.LoadScene("cacah2");
		
     }
      public void cacah3 () {
        
		SceneManager.LoadScene("cacah3");
		
     }
      public void cacah4 () {
        
		SceneManager.LoadScene("cacah4");
		
     }
     public void banding1 () {
        
		SceneManager.LoadScene("1membandingkan");
		
     }
      public void banding2 () {
        
		SceneManager.LoadScene("2membandingkan");
		
     }
      public void banding3 () {
        
		SceneManager.LoadScene("3membandingkan");
		
     }
      public void banding4 () {
        
		SceneManager.LoadScene("4membandingkan");
		
     }
      public void banding5 () {
        
		SceneManager.LoadScene("5membandingkan");
		
     }
     public void banding6 () {
        
		SceneManager.LoadScene("6membandingkan");
		
     }
     public void banding7 () {
        
		SceneManager.LoadScene("7membandingkan");
		
     }
     public void banding8 () {
        
		SceneManager.LoadScene("8membandingkan");
		
     }
     public void banding9 () {
        
		SceneManager.LoadScene("9membandingkan");
		
     }
     public void mengurutkan1 () {
        
		SceneManager.LoadScene("1mengurutkan");
		
     }
     public void mengurutkan2 () {
        
		SceneManager.LoadScene("2mengurutkan");
		
     }
     public void mengurutkan3 () {
        
		SceneManager.LoadScene("3mengurutkan");
		
     }
     public void mengurutkan4 () {
        
		SceneManager.LoadScene("4mengurutkan");
		
     }
     public void mengurutkan5 () {
        
		SceneManager.LoadScene("5mengurutkan");
		
     }
     public void mengurutkan6 () {
        
		SceneManager.LoadScene("6mengurutkan");
		
     }
     public void mengurutkan7 () {
        
		SceneManager.LoadScene("7mengurutkan");
		
     }
     public void penjumlahan1 () {
        
		SceneManager.LoadScene("1_penjumlahan");
		
     }
     public void penjumlahan2 () {
        
		SceneManager.LoadScene("2_penjumlahan");
		
     }
     public void penjumlahan3 () {
        
		SceneManager.LoadScene("3_penjumlahan");
		
     }
     public void penjumlahan4 () {
        
		SceneManager.LoadScene("4_penjumlahan");
		
     }
     public void penjumlahan5 () {
        
		SceneManager.LoadScene("5_penjumlahan");
		
     }
     public void penjumlahan6 () {
        
		SceneManager.LoadScene("6_penjumlahan");
		
     }

    public void map_angkringan()
    {
        Application.OpenURL("https://maps.app.goo.gl/zeTy5UjhaxYegjci7");
    }
    
    public void ExitNow()
    {
        Application.Quit();
    }
    public void playnext()
    {

        SceneManager.LoadScene("wisata2");

    }
    public void playnext1()
    {

        SceneManager.LoadScene("wisata3");

    }
    public void playkembali()
    {

        SceneManager.LoadScene("wisata");

    }

}
