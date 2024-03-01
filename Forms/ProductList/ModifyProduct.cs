using System.Drawing;
using System.Printing.IndexedProperties;
using System.Security.Cryptography.X509Certificates;

namespace NEA1.Forms.ProductList
{
    internal class ModifyProduct : AddProduct
    {
        public ModifyProduct(Image image, ProductDetails product) : base()
        {
            //set window title text
            this.Text = "Modify Product";


            //set values to be of the selected product.
            base.SelectedImage.Image = image;
            SelectedImageLocationLbl.Text = "Current Image";
            priceNumUpDown.Value = (product.Price / 100m);
            stockNumUpDown.Value = product.Stock;
            maxStockNumUpDown.Value = product.MaxStock;
            ProductNameTxtBox.Text = product.Title;
            
        }
    }
}
