using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302223119
{
    internal class SayaTubeVideo
    {
        private int id, playCount;
        private string title;
        public SayaTubeVideo(String title)
        {
            try
            {
                if (title == null || title.Length == 0) { 
                    throw new ArgumentNullException();
                }
                else if (title.Length > 100)
                {
                    throw new ArgumentException();
                }
                this.title = title;
                id = new Random().Next(99999);
                playCount = 0;
            } catch (ArgumentNullException E)
            {
                Console.WriteLine(E.Message + " Title must not be empty.");
            }
            catch (ArgumentException E)
            {
                Console.WriteLine(E.Message + " Title must not exceed 100 character.");

            }
        }
        public void IncreasePlayCount(int count)
        {
            try
            {
                if (count > 10000000) {
                    throw new ArgumentException();
                } else if (playCount + count < 0)
                {
                    throw new OverflowException();
                }
                playCount += count;
            } catch (ArgumentException E)
            {
                Console.WriteLine(E.Message + " Input bigger than 10,000,000.");
            } catch (OverflowException E)
            {
                Console.WriteLine(E.Message+ " playCount will overflow when increased.");
            } 


        }
        public void PrintVideoDetails()
        {
            Console.WriteLine($"title: {title}\nid: {id}\nviews: {playCount}\n");
        }
    }
}
