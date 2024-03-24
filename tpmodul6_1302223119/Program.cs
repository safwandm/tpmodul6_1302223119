// See https://aka.ms/new-console-template for more information


using System.Diagnostics.Contracts;
using tpmodul6_1302223119;

SayaTubeVideo vid1 = new SayaTubeVideo("Tutorial Design By Contract - [MuhammadFaisalShafwanDamanik]");
SayaTubeVideo error1 = new SayaTubeVideo("");
SayaTubeVideo error2 = new SayaTubeVideo("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");


vid1.IncreasePlayCount(10000001);

for (int i = 0; i < 215; ++i)
{
    vid1.IncreasePlayCount(10000000);
}
