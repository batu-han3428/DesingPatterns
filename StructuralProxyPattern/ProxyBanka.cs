using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralProxyPattern
{
    public class ProxyBanka : IBanka
    {
        Banka _banka;
        bool _login;
        string _username, _password;
        
        public ProxyBanka(string username, string password)
        {
            _username = username;
            _password = password;
        }
        bool GirisYap()
        {
            if (_username.Equals("Ali") && _password.Equals("123"))
            {
                _banka = new Banka();
                _login = true;
                Console.WriteLine("Giriş başarılı.");
                return true;
            }
            else
            {
                _login = false;
                Console.WriteLine("Hatalı giriş.");
            }

            return false;
        }
        public bool OdemeYap(double tutar)
        {
            GirisYap();
            if (!_login)
            {
                Console.WriteLine("Hesaba girişbaşarısız. Ödeme yapılamaz.");

                return false;
            }

            _banka.Ode(tutar);

            return true;
        }
    }
}
