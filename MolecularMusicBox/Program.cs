using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using Toub.Sound.Midi;


namespace MolecularMusicBox
{
    class Program
    {
        //E, F, G, A, B, C
        static string[] scale = new string[]
        {
                "E",
                "F",
                "G",
                "A",
                "B",
                "C"
        };

        static int minTone = 3;
        static int maxTone = 8;

        static int initPitch;
        static int tempo1;
        static int tempo2;

        static int tempo1Length;
        static int tempo2Length;

        static int bpm;
        static int loopBeats;

        static int lengthOfBeat; //In milliseconds

        static ulong maxSongLength; //In milliseconds

        static bool quit = false;

        static bool onBeat1 = true;

        static int currentScaleIndex = 0;
        static int currentSemiTone = 4;

        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out initPitch);
            int.TryParse(Console.ReadLine(), out tempo1);
            int.TryParse(Console.ReadLine(), out tempo2);
            int.TryParse(Console.ReadLine(), out bpm);
            int.TryParse(Console.ReadLine(), out loopBeats);
            MidiPlayer.OpenMidi();


            lengthOfBeat = (int)LengthOfBeat(bpm) * 1000;

            tempo1Length = lengthOfBeat * tempo1;
            tempo2Length = lengthOfBeat * tempo2;

            while (!quit)
            {

            }

            MidiPlayer.CloseMidi();
        }

        static double LengthOfBeat(double bpm)
        {
            //bpm / 60 = beats per second
            //60 / bpm = seconds per beat
            return 60 / bpm;
        }
    }

}
