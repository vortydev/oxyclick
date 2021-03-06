﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OxygenScore : MonoBehaviour
{
    private TextMeshProUGUI textmesh;
    private float nextSec;
    public float modifiers = 0;
    public float oxyScore = 0;
    public bool oxyStopped = false;


    private void Start()
    {
        textmesh = GetComponent<TextMeshProUGUI>();
    }

    private void FixedUpdate()
    {
        // Does this every second
        if (Time.fixedTime >= nextSec)
        {
            oxyScore += modifiers;
            PrintOxyScore();
            nextSec++;
        }
    }

    public void AddTapPoints(float points)
    {
        oxyScore += points;
        PrintOxyScore();
    }

    public void PrintOxyScore()
    {
        if (oxyScore < 1.00f)
        {
            textmesh.text = "Oxygen: " + (oxyScore * 1000.00f).ToString("##0") + "g";
        }
        else
        {
            textmesh.text = "Oxygen: " + oxyScore.ToString("0.##") + "kg";
        }
           
    }
}
