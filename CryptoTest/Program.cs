using BitPayAPI;

namespace CryptoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var bp = new BitPay(null, "", "https://test.bitpay.com");

            if (!bp.clientIsAuthorized(BitPay.FACADE_MERCHANT))
            {
                // Get merchant facade authorization code.
                string pairingCode = bp.requestClientAuthorization(BitPay.FACADE_MERCHANT);

                // Client needs to be paired with a merchant account. https://github.com/bitpay/csharp-bitpay-client/blob/master/GUIDE.md
                //Log.Information("Pair this client with your merchant account using the pairing code: " + pairingCode);
                throw new BitPayException("Client is not authorized for Merchant facade.");
            }
        }
    }
}
