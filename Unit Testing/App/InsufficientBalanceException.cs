﻿namespace App;

public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string? message) : base(message) { }
}