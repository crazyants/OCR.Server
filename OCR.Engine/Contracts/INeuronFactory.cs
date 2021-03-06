﻿using OCR.Engine.Models;
using System.IO;

namespace OCR.Engine.Contracts
{
    public interface INeuronFactory
    {
        Neuron Create(char symbol, Stream stream);
    }
}