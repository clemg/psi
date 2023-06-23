// Copyright (c) Microsoft Corporation. All rights reserved.
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

    public PositionData Position
    {
        get { return this.position; }
    }

    public RotationData Rotation
    {
        get { return this.rotation; }
    }

    public bool VAD
    {
        get { return this.vad; }
    }

    public JVAData JVA
    {
        get => this.jvaEvent;
    }

    public PlayersData(PositionData pos, RotationData rot, bool v, JVAData jva)
    {
        position = pos;
        rotation = rot;
        vad = v;
        jvaEvent = jva;
    }
}