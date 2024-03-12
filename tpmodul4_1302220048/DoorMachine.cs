﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302220048
{
    internal class DoorMachine
    {

        public enum DoorState
        {
            Terkunci,
            Terbuka
        }

        public DoorState State { get; private set; }

        public DoorMachine()
        {
            State = DoorState.Terkunci;

        }

        public void Buka()
        {
            State = DoorState.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }

       
        public void Kunci()
        {
            State = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
    }
}
