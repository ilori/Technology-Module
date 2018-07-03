using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace p03_Jarvis
{
    class Program
    {
/*
9223372036854775807
Head 2147483647 20 Leather
Torso 214748364 73 Aluminum
Leg 2147483647 19 20
Leg 2147483646 30 30
Arm 2147483647 20 30
Leg 2147483647 30 30
Arm 2147483646 20 5
Arm 2147483647 30 4
Head 2147483646 19 Leather
Assemble!
*/
        public static void Main()
        {
            var jarvis = new Jarvis();
            var input = long.Parse(Console.ReadLine());
            jarvis.Energy = input;
            var command = Console.ReadLine();
            while (command != "Assemble!")
            {
                var tokens = command.Split(' ');
                var part = tokens[0];
                switch (part)
                {
                    case "Head":
                        var head = new Head();
                        head.Energy = int.Parse(tokens[1]);
                        head.Iq = int.Parse(tokens[2]);
                        head.SkinMaterial = tokens[3];
                        jarvis.AddHead(head);
                        break;
                    case "Torso":
                        var torso = new Torso();
                        torso.Energy = int.Parse(tokens[1]);
                        torso.Size = double.Parse(tokens[2]);
                        torso.Material = tokens[3];
                        jarvis.AddTorso(torso);
                        break;
                    case "Leg":
                        var leg = new Leg();
                        leg.Energy = int.Parse(tokens[1]);
                        leg.Strenght = int.Parse(tokens[2]);
                        leg.Speed = int.Parse(tokens[3]);
                        jarvis.AddLeg(leg);
                        break;
                    case "Arm":
                        var arm = new Arm();
                        arm.Energy = int.Parse(tokens[1]);
                        arm.ReachDistance = int.Parse(tokens[2]);
                        arm.Fingers = int.Parse(tokens[3]);
                        jarvis.AddArm(arm);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(jarvis.ToString());
        }
    }


    public class Head
    {
        public int Energy { get; set; }
        public int Iq { get; set; }
        public string SkinMaterial { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append($"#Head:\n");
            result.Append($"###Energy consumption: {Energy}\n");
            result.Append($"###IQ: {Iq}\n");
            result.Append($"###Skin material: {SkinMaterial}\n");
            return result.ToString();
        }
    }

    public class Torso
    {
        public int Energy { get; set; }
        public double Size { get; set; }
        public string Material { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append($"#Torso:\n");
            result.Append($"###Energy consumption: {Energy}\n");
            result.Append($"###Processor size: {Size:f1}\n");
            result.Append($"###Corpus material: {Material}\n");
            return result.ToString();
        }
    }

    public class Arm
    {
        public int Energy { get; set; }
        public int ReachDistance { get; set; }
        public int Fingers { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append($"#Arm:\n");
            result.Append($"###Energy consumption: {Energy}\n");
            result.Append($"###Reach: {ReachDistance}\n");
            result.Append($"###Fingers: {Fingers}\n");
            return result.ToString();
        }
    }

    public class Leg
    {
        public int Energy { get; set; }
        public int Strenght { get; set; }
        public int Speed { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append($"#Leg:\n");
            result.Append($"###Energy consumption: {Energy}\n");
            result.Append($"###Strength: {Strenght}\n");
            result.Append($"###Speed: {Speed}\n");
            return result.ToString();
        }
    }

    public class Jarvis
    {
        public long Energy { get; set; }
        public Head Head { get; set; }
        public Torso Torso { get; set; }
        public List<Arm> Arms { get; set; }
        public List<Leg> Legs { get; set; }


        public void AddHead(Head head)
        {
            if (Head == null)
            {
                Head = head;
            }
            if (head.Energy < Head.Energy)
            {
                Head = head;
            }
        }

        public void AddTorso(Torso torso)
        {
            if (Torso == null)
            {
                Torso = torso;
            }
            if (torso.Energy < Torso.Energy)
            {
                Torso = torso;
            }
        }

        public void AddArm(Arm arm)
        {
            if (Arms == null)
            {
                Arms = new List<Arm>();
            }
            if (Arms.Count < 2)
            {
                Arms.Add(arm);
            }
            else
            {
                for (int i = 0; i < Arms.Count; i++)
                {
                    if (Arms[i].Energy > arm.Energy)
                    {
                        Arms.RemoveAt(i);
                        Arms.Add(arm);
                    }
                }
            }
        }

        public void AddLeg(Leg leg)
        {
            if (Legs == null)
            {
                Legs = new List<Leg>();
            }
            if (Legs.Count < 2)
            {
                Legs.Add(leg);
            }
            else
            {
                for (int i = 0; i < Legs.Count; i++)
                {
                    if (Legs[i].Energy > leg.Energy)
                    {
                        Legs.RemoveAt(i);
                        Legs.Add(leg);
                    }
                }
            }
        }

        public override string ToString()
        {
            if (Head == null || Torso == null || Arms == null || Legs == null)
            {
                return "We need more parts!";
            }
            var totalEnergy = 0L;
            totalEnergy += Head.Energy;
            totalEnergy += Torso.Energy;
            foreach (var arm in Arms)
            {
                totalEnergy += arm.Energy;
            }
            foreach (var leg in Legs)
            {
                totalEnergy += leg.Energy;
            }
            if (totalEnergy > Energy)
            {
                return "We need more power!";
            }

            var jarvis = new StringBuilder();
            jarvis.Append("Jarvis:\n");
            jarvis.Append(Head);
            jarvis.Append(Torso);
            foreach (var arm in Arms.OrderBy(x => x.Energy))
            {
                jarvis.Append(arm);
            }
            foreach (var leg in Legs.OrderBy(x => x.Energy))
            {
                jarvis.Append(leg);
            }
            return jarvis.ToString();
        }
    }
}