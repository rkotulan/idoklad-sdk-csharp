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
        /// </summary>
        public AgendaClient Agendas
        {
            get { return _agendaClient ?? (_agendaClient = new AgendaClient(_apiContext)); }
        }

        /// <summary>
        /// Contacts section. Here are described methods for working with agendas contacts. API allows creation of invoice only for already created contacts.
        /// </summary>
        public ContactClient Contacts
        {
            get { return _contactClient ?? (_contactClient = new ContactClient(_apiContext)); }
        }

        /// <summary>
        /// Methods for credit note resources.
        /// </summary>
        public CreditNoteClient CreditNotes
        {
            get { return _creditNoteClient ?? (_creditNoteClient = new CreditNoteClient(_apiContext)); }
        }

        /// <summary>
        /// Methods for work with contact information of the invoices (documents).
        /// </summary>
        public DocumentAddressClient DocumentAddresses
        {
            get { return _documentAddressClient ?? (_documentAddressClient = new DocumentAddressClient(_apiContext)); }
        }

        /// <summary>
        /// Methods for issued invoice resources.
        /// </summary>
        public IssuedInvoiceClient IssuedInvoices
        {
            get { return _issuedInvoiceClient ?? (_issuedInvoiceClient = new IssuedInvoiceClient(_apiContext)); }
        }

        /// <summary>
        /// Methods for price list.
        /// </summary>
        public PriceListClient PriceList
        {
            get { return _priceListClient ?? (_priceListClient = new PriceListClient(_apiContext)); }
        }

        /// <summary>
        /// Methods for received invoice resources.
        /// </summary>
        public ReceivedInvoiceClient ReceivedInvoices
        {
            get { return _receivedInvoiceClient ?? (_receivedInvoiceClient = new ReceivedInvoiceClient(_apiContext)); }
        }

        /// <summary>
        /// Method for getting banks.
        /// </summary>
        public BankClient BankClients
        {
            get { return _bankClient ?? (_bankClient = new BankClient(_apiContext)); }
        }

        /// <summary>
        /// Methods for constant symbols.
        /// </summary>
        public ConstantSymbolClient ConstantSymbols
        {
            get { return _constantSymbolClient ?? (_constantSymbolClient = new ConstantSymbolClient(_apiContext)); }
        }

        /// <summary>
        /// Methods for countries. Primary used with contacts.
        /// </summary>
        public CountryClient Countries
        {
            get { return _countryClient ?? (_countryClient = new CountryClient(_apiContext)); }
        }

        /// <summary>
        /// Method for currencies.
        /// </summary>
        public CurrencyClient Currencies
        {
            get { return _currencyClient ?? (_currencyClient = new CurrencyClient(_apiContext)); }
        }

        /// <summary>
        /// Method for exchange rates.
        /// </summary>
        public ExchangeRateClient ExchangeRates
        {
            get { return _exchangeRateClient ?? (_exchangeRateClient = new ExchangeRateClient(_apiContext)); }
        }

        /// <summary>
        /// Method for payment options.
        /// </summary>
        public PaymentOptionClient PaymentOptions
        {
            get { return _paymentOptionClient ?? (_paymentOptionClient = new PaymentOptionClient(_apiContext)); }
        }

        /// <summary>
        /// System functions
        /// </summary>
        public SystemClient System
        {
            get { return _systemClient ?? (_systemClient = new SystemClient(_apiContext)); }
        }

        /// <summary>
        /// Method for work with Vat rates.
        /// </summary>
        public VatRateClient VatRates
        {
            get { return _vatRateClient ?? (_vatRateClient = new VatRateClient(_apiContext)); }
        }
    }
}
