using System;
//using System.Runtime.CompilerServices; INI NOMER 1

//class Sekolah1
//{
//    public string idSekolah1;
//    public string namaSekolah1;
//    public int jumlahPaketDiterima1;

//    public void TampilkanInfo()
//    {
//        Console.WriteLine($"Id Sekolah : {idSekolah1}");
//        Console.WriteLine($"Nama Sekolah : {namaSekolah1}");
//        Console.WriteLine($"Jumlah Paket Diterima : {jumlahPaketDiterima1}");
//    }
//}
//class Sekolah2
//{
//    public string idSekolah2;
//    public string namaSekolah2;
//    public int jumlahPaketDiterima2;

//    public void TampilkanInfo()
//    {
//        Console.WriteLine($"Id Sekolah : {idSekolah2}");
//        Console.WriteLine($"Nama Sekolah : {namaSekolah2}");
//        Console.WriteLine($"Jumlah Paket Diterima : {jumlahPaketDiterima2}");
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        Sekolah1 DataSekolah1 = new Sekolah1();
//        Sekolah2 DataSekolah2 = new Sekolah2();

//        DataSekolah1.idSekolah1 = "123";
//        DataSekolah1.namaSekolah1 = "SDN Kepatihan 01 Jember";
//        DataSekolah1.jumlahPaketDiterima1 = 500;
//        DataSekolah2.idSekolah2 = "321";
//        DataSekolah2.namaSekolah2 = "SDN Kepatihan 06 Jember";
//        DataSekolah2.jumlahPaketDiterima2 = 450;

//        DataSekolah1.TampilkanInfo();
//        DataSekolah2.TampilkanInfo();
//    }
//}

//class paketMBG INI Encapsulation
//{
//    private string idPaket;
//    private string namaPaket; 
//    private string stokDapur
//    {
//        get
//        {
//            return stokDapur;
//        }
//        private set
//        {
//            if (value >= 0)
//            { stokDapur = value;
//            }
//            else
//            {
//                Console.WriteLine("Stok tidak boleh bernilai negatif!")
//            }
//        }
//    }
//    private void KurangiStok(int jumlah)
//    {
//        if (jumlah > 0)
//        {
//            stokDapur -= jumlah;
//            Console.WriteLine(
//                $"Stok Dapur: {jumlah}"
//            );
//        }
//        else
//        {
//            Console.WriteLine(
//                "Jumlah setor harus lebih dari 0."
//            );
//        }
//    }
//    class Program
//    {
//        static void Main()
//       {
//            paketMBG Paket = new paketMBG("123", "Paket Reguler", 1000);

//            Console.WriteLine($"Id Paket : {idPaket}");
//            Console.WriteLine($"Nama Paket : {namaPaket}");
//            Console.WriteLine($"Stok Dapur : {stokDapur}");

//            stokDapur.KurangiStok(550);

//            Console.WriteLine($"Stok akhir: {stokDapur.KurangiStok}");

//            Tidak diperbolehkan : stokDapur = -1;
//        }
//    }


//class paketMBG INI INHERITANCE
//{
//    private object idPaket;
//    private string namaPaket;
//    private string stokDapur;
//    private string harga;
//    private string isi;

//    public paketMBG() { }

//    public paketMBG(string harga, string isi)
//    {
//        this.harga = harga;
//        this.isi = isi;
//    }

//    public paketMBG(string idPaket, string namaPaket, string stokDapur)
//    {
//        this.idPaket = idPaket;
//        this.namaPaket = namaPaket;
//        this.stokDapur = stokDapur;
//    }

//    public void Paket()
//    {
//        Console.WriteLine($"Id Paket : {idPaket}");
//        Console.WriteLine($"Nama Paket : {namaPaket}");
//        Console.WriteLine($"Stok Dapur : {stokDapur}");
//    }
//}

//class paketReguler : paketMBG
//{
//    public paketReguler(string harga, string isi) : base(harga, isi) { }
//        public void TampilkanInfo()
//        {
//        Console.WriteLine($"Harga Paket : {harga}");
//            Console.WriteLine($"Isi : {isi}");
//        }
//    }

//    class paketKhusus : paketMBG
//    {
//        public paketKhusus(string harga, string isi, string jenisDiet) : base(harga, isi, jenisDiet) { }
//        public void TampilkanInfo()
//        {
//            Console.WriteLine($"Harga Paket : {harga}");
//            Console.WriteLine($"Isi : {isi}");
//            Console.WriteLine($"Jenis Diet : {jenisDiet}");


//        }
//    }

//class Program
//{
//    static void Main()
//    {
//        paketReguler reguler = new paketReguler("Rp 15.000", "nasi, ayam, sayur, dan buah");
//        paketKhusus khusus = new paketKhusus("Rp 20.000", "nasi, sayur, dan buah", "Vegetarian");

//        paketReguler.TampilkanInfo();
//        paketKhusus.TampilkanInfo();

//    }
//}


//public class paketMBG POLYMORPHISM
//{
//    public virtual void HitungBiaya()
//    {
//        Console.WriteLine("Jumlah Biaya : ");
//    }
//}

//public class paketReguler : paketMBG
//{
//    public override void HitungBiaya()
//        private void KurangiStok(int jumlah)
//    {
//        if (jumlah > 0)
//        {
//            harga *= jumlah;

//            {
//        Console.WriteLine("Jumlah Biaya : ");
//    }

//}

//public class paketKhusus : paketMBG
//{
//    public override void HitungBiaya()
//            private void KurangiStok(int jumlah)
//        {
//            if (jumlah > 0)
//            {
//                harga *= jumlah;

//                {
//                    Console.WriteLine("Jumlah Biaya : ");
//    }

//}
//public class Program
//{
//    public static void Main()
//    {
//        paketMBG reguler = new paketReguler();

//        paketMBG khusus = new paketKhusus();
//        reguler.HitungBiaya();
//        khusus.HitungBiaya();

