// See https://aka.ms/new-console-template for more information


using System.Diagnostics.Contracts;
using tpmodul6_1302223119;

SayaTubeVideo vid1 = new SayaTubeVideo("Tutorial Design By Contract - [MuhammadFaisalShafwanDamanik]");
vid1.IncreasePlayCount(10000000);
vid1.PrintVideoDetails();

SayaTubeVideo error1 = new SayaTubeVideo("");
SayaTubeVideo error2 = new SayaTubeVideo("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

error1.IncreasePlayCount(10000001);

for (int i = 0; i < 215; ++i)
{
    error2.IncreasePlayCount(10000000);
}