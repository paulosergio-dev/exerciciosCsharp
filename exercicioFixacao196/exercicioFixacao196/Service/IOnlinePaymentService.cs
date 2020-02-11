using System;


namespace exercicioFixacao196.Service
{
    interface IOnlinePaymentService
    {
        Double PaymentFee(Double amount);
        Double Interest(Double amount, int months);


    }
}
