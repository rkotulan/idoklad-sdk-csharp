using System;
using IdokladSdk.Clients;

namespace IdokladSdk
{
    public class ApiExplorer
    {
        private readonly ApiContext _apiContext;
        private AgendaClient _agendaClient;
        private ContactClient _contactClient;
        private CreditNoteClient _creditNoteClient;
        private DocumentAddressClient _documentAddressClient;
        private IssuedInvoiceClient _issuedInvoiceClient;
        private PriceListClient _priceListClient;
        private ReceivedInvoiceClient _receivedInvoiceClient;
        private BankClient _bankClient;
        private ConstantSymbolClient _constantSymbolClient;
        private CountryClient _countryClient;
        private CurrencyClient _currencyClient;
        private ExchangeRateClient _exchangeRateClient;
        private PaymentOptionClient _paymentOptionClient;
        private SystemClient _systemClient;
        private VatRateClient _vatRateClient;

        public ApiExplorer(ApiContext apiContext)
        {
            _apiContext = apiContext;
        }

        /// <summary>
        /// Methods for manipulating with Agenda resources.
        /// API 1.0
        /// </summary>
        public AgendaClient Agendas => _agendaClient ?? (_agendaClient = new AgendaClient(_apiContext));

        /// <summary>
        /// Contacts section. Here are described methods for working with agendas contacts. API allows creation of invoice only for already created contacts.
        /// API 1.0
        /// </summary>
        public ContactClient Contacts => _contactClient ?? (_contactClient = new ContactClient(_apiContext));

        /// <summary>
        /// Methods for credit note resources.
        /// API 1.0
        /// </summary>
        public CreditNoteClient CreditNotes => _creditNoteClient ?? (_creditNoteClient = new CreditNoteClient(_apiContext));

        /// <summary>
        /// Methods for work with contact information of the invoices (documents).
        /// API 1.0
        /// </summary>
        public DocumentAddressClient DocumentAddresses => _documentAddressClient ?? (_documentAddressClient = new DocumentAddressClient(_apiContext));

        /// <summary>
        /// Methods for issued invoice resources.
        /// API 1.0
        /// </summary>
        public IssuedInvoiceClient IssuedInvoices => _issuedInvoiceClient ?? (_issuedInvoiceClient = new IssuedInvoiceClient(_apiContext));

        /// <summary>
        /// Methods for price list.
        /// /// API 1.0
        /// </summary>
        public PriceListClient PriceList => _priceListClient ?? (_priceListClient = new PriceListClient(_apiContext));

        /// <summary>
        /// Methods for received invoice resources.
        /// API 1.0
        /// </summary>
        public ReceivedInvoiceClient ReceivedInvoices => _receivedInvoiceClient ?? (_receivedInvoiceClient = new ReceivedInvoiceClient(_apiContext));

        /// <summary>
        /// Method for getting banks.
        /// API 1.0
        /// </summary>
        public BankClient BankClients => _bankClient ?? (_bankClient = new BankClient(_apiContext));

        /// <summary>
        /// Methods for constant symbols.
        /// API 1.0
        /// </summary>
        public ConstantSymbolClient ConstantSymbols => _constantSymbolClient ?? (_constantSymbolClient = new ConstantSymbolClient(_apiContext));

        /// <summary>
        /// Methods for countries. Primary used with contacts.
        /// API 1.0
        /// </summary>
        public CountryClient Countries => _countryClient ?? (_countryClient = new CountryClient(_apiContext));

        /// <summary>
        /// Method for currencies.
        /// API 1.0
        /// </summary>
        public CurrencyClient Currencies => _currencyClient ?? (_currencyClient = new CurrencyClient(_apiContext));

        /// <summary>
        /// Method for exchange rates.
        /// API 1.0
        /// </summary>
        public ExchangeRateClient ExchangeRates => _exchangeRateClient ?? (_exchangeRateClient = new ExchangeRateClient(_apiContext));

        /// <summary>
        /// Method for payment options.
        /// API 1.0
        /// </summary>
        public PaymentOptionClient PaymentOptions => _paymentOptionClient ?? (_paymentOptionClient = new PaymentOptionClient(_apiContext));

        /// <summary>
        /// System functions
        /// API 1.0
        /// </summary>
        public SystemClient System => _systemClient ?? (_systemClient = new SystemClient(_apiContext));

        /// <summary>
        /// Method for work with Vat rates.
        /// API 1.0
        /// </summary>
        public VatRateClient VatRates => _vatRateClient ?? (_vatRateClient = new VatRateClient(_apiContext));

        /// <summary>
        /// Ensure current newest version
        /// </summary>
        private void EnsureVersion()
        {
            if (_apiContext.ApiVersion < 2)
            {
                throw new Exception(Resources.Messages.ClientAvailableOnlyWithApi20);
            }
        }
    }
}
