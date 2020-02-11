using System;


namespace exercicioFixacao196.Service
{
    class PaypalService : IOnlinePaymentService
    {
     
        double IOnlinePaymentService.PaymentFee(double amount)
        {
            throw new NotImplementedException();
        }

        double IOnlinePaymentService.Interest(double amount, int months)
        {
            throw new NotImplementedException();
        }
        }
   

        public double (double amount, int month)
    {
        double value = amount + amount * 0.01 * month;
        value += value * 0.02;
        return value;
    }



}
