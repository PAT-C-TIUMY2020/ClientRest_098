using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Net;
using static ClientRest_098_Nashrul.Program;

namespace ClientRest_098_Nashrul
{
    class ClassData
    {
        public void getData()
        {
            //var type data yang tidak peduli pada bentuk, tapi isinya
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

            foreach (var mhs in data)
            {
                Console.WriteLine("NIM :  " + mhs.nama);
                Console.WriteLine("Nama :  " + mhs.nim);
                Console.WriteLine("Prodi :  " + mhs.prodi);
                Console.WriteLine("Angkatan :  " + mhs.angkatan);
            }
            Console.ReadLine();
        }
    }

    
}
