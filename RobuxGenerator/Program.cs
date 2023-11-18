using System;
using NAudio.Wave;

class Program
{
    static void Main()
    {
        string loading = "██";

        string filePath = "FunnySound.wav";

        Console.WriteLine("Hello! Thats Free robux generator for roblox!");
        Console.WriteLine("Please Enter your username in roblox");
        string b = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Now enter how much robux do you need");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Thanks wait a moment and we will sent {a} robux to {b}");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Loading is on {20 * i}%");
            Console.WriteLine(loading);
            loading = loading + "██";
            Thread.Sleep(2000);
            Console.Clear();
        }

        Console.WriteLine(@"KK00000000OOO000KK00OOOOOOOkkkOOOO0K00KKK0Okkxxxxk0KKKKKKK00
XKKKKK00000000000OOkOOkkkkxocccc::coxkOOOOOkkxkkkkkOO0000KK0
XXXXXXXXXK00000KKK00OOOOkxo;'...''',;lxOOOkkkkkkkkkO0KKKXXNX
XXXXXXXXXKK00K0KKKKKOOOOkdlcccccccc:;;o0K0OkkkkkO0KKXXXXXNNX
XKXXK000KKK00KKK0000OOOkolooodxxxxkxl;lOOkkkkkkkkkO00KKXXNNN
K000000KXXK000K00KXKXX0kxdoccloddodxocxOOkkOOkxkOOkkkO00KXNN
0KXXKKKXNNK0KKKXNNNXXXKkxxolllldddddod0KK0kkkkkkO00OkkkOO0KX
KXNNXKKKXXKKKKKNWNNXXXXOkxolllodxxxxdkKKKK0OkxkkOK0OkO00OkkO
0KXX00KXKKK00KKNWNNNXXXK0kolloddxxxkO0KKKK0OkxkkkOOkOOKK0Okk
KK000XNNNXK000KKXNNXXXK0OxolloddddxOKKKKKK0OkxxkxO0OOO00OkOO
XXXKKXNNNX00KKK00KXXK0Okkdllllooddxdx0KK00kkkkkxk0KKKOO00OOO
XNNX0KXNNK000KK0OO0OOkOkxolloooddkd;':lddxxkOkkkk0KKK0KXXKOk
0KXXK0XXX0OOO000K0kdlokOdoolloodOOl'.....,,;:cloxO0K0OKXX0kk
O0KK0O000OkOOkxol:'..;dkdccoxkOOkc'.............,d00OOKK0Okk
OOO00000OOkkkc'......';clccoodxd:................:xOkkO0kkO0
OkkOKXXXK0OOx;.........'cccclll:'.................ckOkkkxkO0
kkkO0KXXKOkkd,.........'cooccc:,..................;x0OkkxkOO
kOOkO0KXKOkkd,.........'cxd::;'....................:kOkkkkOK
O00OkOKXKOOko'.........':ol::,...............  .....,cdk0OOK
0K0OOO0KKOkko'..........;:;;,......;ccccc;...  ........;oxk0
0Okk00O00Okko,.. .......,:;;'......,:cllll:.... .........,ok
kkOOOOOOOkkkd'..........,:;,'.......':cllol;..............lk
kO0KKOkkkkxxl'.... .....';;,.. .... ....':c,..............:x
kO00000Okkxxl,..';;::;'.';;'.   .        ..  ..'..........:d
kOO0000Okxxxd;.':cc::;'..,,..                 .''.....',;ldx
xkO0Okkkxxdddc,..,;;;;'..,,..        ...      .:oooooddxkkxd
oxkkxxxxxxddxdlc,..''....,'.                  .;dxxdddxxxdoo
doodxkkxddddxkxdl:;,.  .....              .....'oxdddddddddd
dddxkkkxddddxkkxoloc....,,..               .. ..:dddddoddddd
ooodxkkxdddodxxdoll;...';,'.               ..  .,oddddoodddd
");

        using (var reader = new WaveFileReader(filePath))
        {
            using (var waveOut = new WaveOutEvent())
            {
                waveOut.Init(reader);

                waveOut.Volume = 0.2f;

                waveOut.Play();

                Console.ReadKey();

                waveOut.Stop();
            }
        }
    }
}