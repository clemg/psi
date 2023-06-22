﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using System.Numerics;
using PipelineRejeuxDonnees;

#pragma warning disable

[System.Serializable]
public class PlayersData
{
    public PositionData position;
    public RotationData rotation;
    public bool vad;
    public JVAData jvaEvent;

    public bool VAD
    {
        get { return this.vad; }
    }
    public PositionData Position
    {
        get { return this.position; }
    }

    public PlayersData(PositionData pos, RotationData rot, bool v, JVAData jva)
    {
        position = pos;
        rotation = rot;
        vad = v;
        jvaEvent = jva;
    }
}