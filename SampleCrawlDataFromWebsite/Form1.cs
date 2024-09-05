
namespace SampleCrawlDataFromWebsite
{
    using HtmlAgilityPack;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //URL of target website
            tbxUrl.Text = "https://www.xtmobile.vn/samsung/?p=1&sort=2";
        }

        private async void btnCrawl_Click(object sender, EventArgs e)
        {
            CrawlPhoneDataOfXtMobile();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        public async void CrawlPhoneDataOfXtMobile()
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    //Add header for http request
                    httpClient.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/128.0.0.0 Safari/537.36");

                    //URL of target website
                    if (String.IsNullOrEmpty(tbxUrl.Text))
                        tbxUrl.Text = "https://www.xtmobile.vn/samsung/?p=1&sort=2";

                    HttpResponseMessage response = await httpClient.GetAsync(tbxUrl.Text);

                    if (response.IsSuccessStatusCode)
                    {
                        List<ProductInfo> productsInfo = new List<ProductInfo>();

                        string content = await response.Content.ReadAsStringAsync();

                        HtmlDocument htmlDoc = new HtmlDocument();
                        htmlDoc.LoadHtml(content);

                        var products = htmlDoc.DocumentNode.SelectNodes("//div[@class='product-base-grid']");

                        if (products != null)
                        {
                            foreach (var item in products)
                            {
                                ProductInfo productInfo = new ProductInfo();

                                var ProductLink = item.SelectSingleNode(".//a/@href").Attributes["href"]?.Value ?? "N/A";
                                var ProductName = item.SelectSingleNode(".//h3")?.InnerText ?? "N/A";
                                var ProductPrice = item.SelectSingleNode(".//div[@class='price']/text()")?.InnerText ?? "N/A";
                                var ProductOldPrice = item.SelectSingleNode(".//div[@class='price']/span/text()")?.InnerText ?? "N/A";
                                var Discount = item.SelectSingleNode(".//div[@class='price']/span/span/text()")?.InnerText ?? "N/A";

                                productInfo.ProductLink = ProductLink;
                                productInfo.ProductName = ProductName;
                                productInfo.ProductPrice = ProductPrice;
                                productInfo.ProductOldPrice = ProductOldPrice;
                                productInfo.Discount = Discount;

                                productsInfo.Add(productInfo);
                            }

                            //Show to Data Grip View
                            dataGridView1.DataSource = productsInfo;

                        }
                        else lblStatus.Text = "There are no data";
                    }
                    else
                    {
                        lblStatus.Text = "There are no response from website";
                    }

                }
                catch (Exception ex)
                {
                    lblStatus.Text = $"An error occurred: {ex.Message}";
                }
            }
        }

    }
}
