using System;
using UnityEngine;

public interface CurrencyInterface
{

    public void setCurrencyCount(int currencyCount);

    public void increaseCurrencyCount(int increase);

    public void decreaseCurrencyCount(int decrease);

    public int getCurrencyCount();
}
