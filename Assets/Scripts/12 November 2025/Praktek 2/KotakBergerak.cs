using UnityEngine;

public class KotakBergerak : MonoBehaviour
{
    public ArahGerak arahgerak = ArahGerak.kanan;
    //ini adalah deklarasi  gameobject dengan tipe data class ArahGerak
    //digunakan untuk script ini bisa berkomunikasi dengan gameobject yang memiliki class arahgerak
    //kemudian diberikan nilai awal yaitu ArahGerak.kanan
    public float kecepatan = 5.0f;
    //ini adalah deklarasi gameobject dengan bertipe float dan tipe data class kecepatan
    //kemudian diberikan nilai awal yaitu 5 per frame
    public InteraksiUI12Nov interaksiui12nov;
    //ini adalah deklarasi gameobject dengan tipe data class InteraksiUI12Nov
    //ini digunakan untuk script ini bisa berkomunikasi dengan gameobject yang memiliki class interaksiui12nov
    //setelah deklarasi ini, harus assign gameobject dari hierarcy ke inspectornya

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (arahgerak) //digunakan untuk mengecek nilai pada variabel arahgerak
        {
            case ArahGerak.atas: //jika nilai dari arahgerak adalah atas, maka akan menjalankan perintah didalam casenya
                gameObject.transform.Translate(0, kecepatan * Time.deltaTime, 0); //mengubah arah gameobject pada sumbu y dengan nilai dari kecepatan yang sudah ditentukan sebelumnya
                break; //menghentikan fungsi switch, jika sudah memenuhi case sebelumnya
            case ArahGerak.bawah: //jika nilai dari arahgerak adalah bawah, maka akan menjalankan perintah didalam casenya
                gameObject.transform.Translate(0, -kecepatan * Time.deltaTime, 0); //mengubah arah gameobject pada sumbu y dengan nilai dari kecepatan yang sudah ditentukan sebelumnya
                break; //menghentikan fungsi switch, jika sudah memenuhi case sebelumnya
            case ArahGerak.kiri: //jika nilai dari arahgerak adalah kiri, maka akan menjalankan perintah didalam casenya
                gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0); //mengubah arah gameobject pada sumbu x dengan nilai dari kecepatan yang sudah ditentukan sebelumnya
                break; //menghentikan fungsi switch, jika sudah memenuhi case sebelumnya
            case ArahGerak.kanan: //jika nilai dari arahgerak adalah kanan, maka akan menjalankan perintah didalam casenya
                gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0); //mengubah arah gameobject pada sumbu x dengan nilai dari kecepatan yang sudah ditentukan sebelumnya
                break; //menghentikan fungsi switch, jika sudah memenuhi case sebelumnya
        }
    }
    void OnCollisionEnter2D(Collision2D collision) //membuat fungsi jika terjadi collision antar 2 objek atau lebih
    {
        if (collision.gameObject.CompareTag("Dinding")) //mengecek apakah collision yang dilakukan gameobject memiliki tag "Dinding"
        {
            Debug.Log("Kotak Menabrak Dinding"); //menampilkan teks tersebut ke console, jika memenuhi kondisi if di atas
            if (arahgerak == ArahGerak.atas) //mengecek apakah nilai arahgerak sama dengan nilai dari ArahGerak yaitu atas
            {
                arahgerak = ArahGerak.bawah; //jika memenuhi kondisi if sebelumnya, mengubah nilai dari arahgerak menjadi bawah
            }
            else if (arahgerak == ArahGerak.bawah) //mengecek apakah nilai arahgerak sama dengan nilai dari ArahGerak yaitu bawah
            {
                arahgerak = ArahGerak.atas; //jika memenuhi kondisi if sebelumnya, mengubah nilai dari arahgerak menjadi atas
            }
            else if (arahgerak == ArahGerak.kanan)//mengecek apakah nilai arahgerak sama dengan nilai dari ArahGerak yaitu kanan
            {
                arahgerak = ArahGerak.kiri; //jika memenuhi kondisi if sebelumnya, mengubah nilai dari arahgerak menjadi kiri
            }
            else //jika tidak memenuhi semua kondisi, maka akan dijalankan perintah dibawah
            {
                arahgerak = ArahGerak.kanan; //mengubah nilai dari arahgerak menjadi kanan
            }
            interaksiui12nov.skor++; //mengubah nilai dari skor pada class interaksiui12nov dengan menambahkan +1
            TambahSkor(); //memanggil fungsi TambahSkor dan memprosesnya
        }
    }
    
    public void TambahSkor() //membuat fungsi baru dengan nama TambahSkor
    {
        interaksiui12nov.TeksSkor.text = "Skor: " + interaksiui12nov.skor.ToString(); //mengubah isi text pada gameobject dengan class interaksiui12nov dan bertipe string
    }
}
//pendeklarasian sebuah enumator dengan nama ArahGerak
//isi enumatornya adalah atas, bawah, kiri, kanan
public enum ArahGerak 
{
    atas,
    bawah,
    kiri,
    kanan
}