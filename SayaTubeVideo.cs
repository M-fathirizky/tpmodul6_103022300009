using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022300009
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {

            Contract.Requires(!string.IsNullOrEmpty(title), "Judul video tidak boleh kosong.");
            Contract.Requires(title.Length <= 100, "Judul video tidak boleh lebih dari 100 karakter.");

            if (string.IsNullOrEmpty(title))
                throw new ArgumentException("Judul video tidak boleh kosong.");
            if (title.Length > 100)
                throw new ArgumentException("Judul video tidak boleh lebih dari 100 karakter.");

            Random random = new Random();
            this.id = random.Next(10000, 99999);

            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            Contract.Requires(playCount > 0 && playCount <= 10000000, "Jumlah play count harus antara 1 dan 10.000.000.");

            if (playCount <= 0 || playCount > 10000000)
                throw new ArgumentOutOfRangeException(nameof(playCount), "Jumlah play count harus antara 1 dan 10.000.000.");

            checked
            {
                this.playCount += playCount;
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Video: " + id);
            Console.WriteLine("Judul Video: " + title);
            Console.WriteLine("Jumlah Play: " + playCount);
        }
    }
}
