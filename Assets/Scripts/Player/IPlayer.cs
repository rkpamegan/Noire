﻿/// <summary>
/// Interface for player. Refer here for the available public functions for the Player Instance
/// </summary>

public interface IPlayer
{
    bool IsWalking();
    bool IsIdle();
    bool IsCasting();
    bool IsDead();
    bool CanCastAbility();
    float GetPlayerHitBoxHeight();
    Weapon GetWeapon();
    bool AddItem(CollectableItemSO item);
    bool RemoveItem(CollectableItemSO item);
}