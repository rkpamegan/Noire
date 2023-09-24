using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyManager : MonoBehaviour, CurrencyInterface
{
    private int currencyCount;

    public int getCurrencyCount()
    {
        return currencyCount;
    }

    public void setCurrencyCount(int currencyCount)
    {
        this.currencyCount = currencyCount;
    }

    public void increaseCurrencyCount(int increase)
    {
        currencyCount = currencyCount + increase;
    }

    public void decreaseCurrencyCount(int decrease)
    {
        if (currencyCount - decrease >= 0)
        {
            currencyCount = currencyCount - decrease;
        }
    }



}
