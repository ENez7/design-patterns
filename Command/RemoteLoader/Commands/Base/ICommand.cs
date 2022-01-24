﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteLoader.Commands.Base
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}
