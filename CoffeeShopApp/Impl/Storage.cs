using CoffeeShopApp.Impl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace CoffeeShopApp.Impl {

    public class Storage {
        private const string _LogFile = "Log.txt";
        public const string _JsonFile = "CoffeeShopData.json";
        public CoffeeShop NewCoffeeShop = new CoffeeShop();

        public void SerializeToJson() {

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string data = serializer.Serialize(NewCoffeeShop);

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            File.WriteAllText(path, data);

        }

        public void DeserializeFromJson() {
            try {

                JavaScriptSerializer serializer = new JavaScriptSerializer();

                string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);

                if (File.Exists(path)) {
                    string data = File.ReadAllText(path);

                    NewCoffeeShop = serializer.Deserialize<CoffeeShop>(data);
                }


            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

        }

    }

}
