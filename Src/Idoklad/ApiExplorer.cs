using IdokladSdk.Clients;

namespace IdokladSdk
{
    public class ApiExplorer
    {
        private readonly ApiContext apiContext;
        private AgendaClient agendaClient;
        private ContactClient contactClient;
        private CreditNoteClient creditNoteClient;
        private DocumentAddressClient documentAddressClient;
        private IssuedInvoiceClient issuedInvoiceClient;
        private PriceListClient priceListClient;
        private ReceivedInvoiceClient receivedInvoiceClient;
        private BankClient bankClient;
        private ConstantSymbolClient constantSymbolClient;
        private CountryClient countryClient;
        private CurrencyClient currencyClient;
        private ExchangeRateClient exchangeRateClient;
        private PaymentOptionClient paymentOptionClient;
        private SystemClient systemClient;
        private VatRateClient vatRateClient;

        public ApiExplorer(ApiContext apiContext)
        {
            this.apiContext = apiContext;
        }

        /// <summary>
        /// Methods for manipulating with Agenda resources.
        /// </summary>
        public AgendaClient Agendas
        {
            get { return this.agendaClient ?? (this.agendaClient = new AgendaClient(apiContext)); }
        }

        /// <summary>
        /// Contacts section. Here are described methods for working with agendas contacts. API allows creation of invoice only for already created contacts.
        /// </summary>
        public ContactClient Contacts
        {
            get { return this.contactClient ?? (this.contactClient = new ContactClient(apiContext)); }
        }

        /// <summary>
        /// Methods for credit note resources.
        /// </summary>
        public CreditNoteClient CreditNotes
        {
            get { return this.creditNoteClient ?? (this.creditNoteClient = new CreditNoteClient(apiContext)); }
        }

        /// <summary>
        /// Methods for work with contact information of the invoices (documents).
        /// </summary>
        public DocumentAddressClient DocumentAddresses
        {
            get { return this.documentAddressClient ?? (this.documentAddressClient = new DocumentAddressClient(apiContext)); }
        }

        /// <summary>
        /// Methods for issued invoice resources.
        /// </summary>
        public IssuedInvoiceClient IssuedInvoices
        {
            get { return this.issuedInvoiceClient ?? (this.issuedInvoiceClient = new IssuedInvoiceClient(apiContext)); }
        }

        /// <summary>
        /// Methods for price list.
        /// </summary>
        public PriceListClient PriceList
        {
            get { return this.priceListClient ?? (this.priceListClient = new PriceListClient(apiContext)); }
        }

        /// <summary>
        /// Methods for received invoice resources.
        /// </summary>
        public ReceivedInvoiceClient ReceivedInvoices
        {
            get { return this.receivedInvoiceClient ?? (this.receivedInvoiceClient = new ReceivedInvoiceClient(apiContext)); }
        }

        /// <summary>
        /// Method for getting banks.
        /// </summary>
        public BankClient BankClients
        {
            get { return this.bankClient ?? (this.bankClient = new BankClient(apiContext)); }
        }

        /// <summary>
        /// Methods for constant symbols.
        /// </summary>
        public ConstantSymbolClient ConstantSymbols
        {
            get { return this.constantSymbolClient ?? (this.constantSymbolClient = new ConstantSymbolClient(apiContext)); }
        }

        /// <summary>
        /// Methods for countries. Primary used with contacts.
        /// </summary>
        public CountryClient Countries
        {
            get { return this.countryClient ?? (this.countryClient = new CountryClient(apiContext)); }
        }

        /// <summary>
        /// Method for currencies.
        /// </summary>
        public CurrencyClient Currencies
        {
            get { return this.currencyClient ?? (this.currencyClient = new CurrencyClient(apiContext)); }
        }

        /// <summary>
        /// Method for exchange rates.
        /// </summary>
        public ExchangeRateClient ExchangeRates
        {
            get { return this.exchangeRateClient ?? (this.exchangeRateClient = new ExchangeRateClient(apiContext)); }
        }

        /// <summary>
        /// Method for payment options.
        /// </summary>
        public PaymentOptionClient PaymentOptions
        {
            get { return this.paymentOptionClient ?? (this.paymentOptionClient = new PaymentOptionClient(apiContext)); }
        }

        /// <summary>
        /// System functions
        /// </summary>
        public SystemClient System
        {
            get { return this.systemClient ?? (this.systemClient = new SystemClient(apiContext)); }
        }

        /// <summary>
        /// Method for work with Vat rates.
        /// </summary>
        public VatRateClient VatRates
        {
            get { return this.vatRateClient ?? (this.vatRateClient = new VatRateClient(apiContext)); }
        }
    }
}
