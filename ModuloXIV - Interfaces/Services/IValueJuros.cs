using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloXIV___Interfaces.Services
{
    interface IValueJuros
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
