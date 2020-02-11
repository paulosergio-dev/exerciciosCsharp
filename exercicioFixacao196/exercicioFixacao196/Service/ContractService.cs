

namespace exercicioFixacao196.Service
{
    class ContractService
    {
        private IOnlinePaymentService _IOnlinePaymentService;

        public ContractService(IOnlinePaymentService _IOnlinePaymentService)
        {
            this._IOnlinePaymentService = _IOnlinePaymentService;
        }



    }
}
