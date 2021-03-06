﻿using OCR.Engine.Models;

namespace OCR.Engine.Contracts
{
    public interface INeuronRecognizeService
    {
        bool IsRecognized(int[,] input, Neuron neuron);

        void Learn(int[,] input, Neuron neuron);

        void Forget(int[,] input, Neuron neuron);
    }
}