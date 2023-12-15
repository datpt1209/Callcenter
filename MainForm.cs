using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
namespace WinFormsApp2
{
    public partial class MainForm : Form
    {
        IFirebaseConfig Config = new FirebaseConfig()
        {
            AuthSecret = "hxglBMLQcKSQOCgpilSc62e9CXJpA51q8rBeLUGw",
            BasePath = "https://uber-ola-and-indrive-clo-2b5a0-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(Config);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.ToString()}");
            }

            LoadRideRequestList();
        }

        private void LoadRideRequestList()
        {
            FirebaseResponse result = client.Get(@"All Ride Requests");
            Dictionary<string, RideRequest> data = JsonConvert.DeserializeObject<Dictionary<string, RideRequest>>(result.Body.ToString());

            int stt = 1;
            foreach (var item in data)
            {
                ListViewItem listViewItem = new ListViewItem(stt++.ToString());
                listViewItem.SubItems.Add(item.Value.userName);
                listViewItem.SubItems.Add(item.Value.userPhone);
                listViewItem.SubItems.Add(item.Value.time);
                listViewItem.SubItems.Add(item.Value.originAddress);
                listViewItem.SubItems.Add(item.Value.destinationAddress);

                listView1.Items.Add(listViewItem);
            }
        }

        private async void btDieuphoi_Click(object sender, EventArgs e)
        {
            RideRequest rideRequest = GetInformationCall();

            InsertRideRequest(rideRequest);
            var index = listView1.Items.Count;
            ListViewItem listViewItem = new ListViewItem(index++.ToString());
            listViewItem.SubItems.Add(rideRequest.userName);
            listViewItem.SubItems.Add(rideRequest.userPhone);
            listViewItem.SubItems.Add(rideRequest.time);
            listViewItem.SubItems.Add(rideRequest.originAddress);
            listViewItem.SubItems.Add(rideRequest.destinationAddress);

            listView1.Items.Add(listViewItem);
        }

        private async void InsertRideRequest(RideRequest rideRequest)
        {
            var data = new RideRequest
            {
                rideRequestId = rideRequest.rideRequestId,
                userName = rideRequest.userName,
                userPhone = rideRequest.userPhone,
                time = rideRequest.time,
                originAddress = rideRequest.originAddress,
                destinationAddress = rideRequest.destinationAddress
            };

            SetResponse response = await client.SetAsync("All Ride Requests/" + data.rideRequestId, data);

            RideRequest result = response.ResultAs<RideRequest>();

            MessageBox.Show("Succesfull");
        }

        private RideRequest GetInformationCall()
        {
            RideRequest result = new RideRequest();
            result.rideRequestId = Guid.NewGuid().ToString();
            result.userName = txtName.Text;
            result.userPhone = txbSdt.Text;
            result.time = DateTime.Now.ToString();
            result.originAddress = lbOriginAddress.Text;
            result.destinationAddress = lbDestinationAddress.Text;

            return result;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtName.Text = item.SubItems[1].Text;
                txbSdt.Text = item.SubItems[2].Text;
                lbOriginAddress.Text = item.SubItems[4].Text;
                lbDestinationAddress.Text = item.SubItems[5].Text;

            }

        }

        private void txbSonhadi_TextChanged(object sender, EventArgs e)
        {
            lbOriginAddress.Text = string.Join(", ", new string[] { txbSonhadi.Text, txbphuongdi.Text, txbquandi.Text, txtTinhdi.Text });

        }

        private void txbphuongdi_TextChanged(object sender, EventArgs e)
        {
            lbOriginAddress.Text = string.Join(", ", new string[] { txbSonhadi.Text, txbphuongdi.Text, txbquandi.Text, txtTinhdi.Text });

        }

        private void txbquandi_TextChanged(object sender, EventArgs e)
        {
            lbOriginAddress.Text = string.Join(", ", new string[] { txbSonhadi.Text, txbphuongdi.Text, txbquandi.Text, txtTinhdi.Text });

        }

        private void txtTinhdi_TextChanged(object sender, EventArgs e)
        {
            lbOriginAddress.Text = string.Join(", ", new string[] { txbSonhadi.Text, txbphuongdi.Text, txbquandi.Text, txtTinhdi.Text });

        }

        private void txbSonhaDen_TextChanged(object sender, EventArgs e)
        {
            lbDestinationAddress.Text = string.Join(", ", new string[] { txbSonhaDen.Text, txbPhuongDen.Text, txbQuanDen.Text, txbTinhDen.Text });
        }

        private void txbPhuongDen_TextChanged(object sender, EventArgs e)
        {
            lbDestinationAddress.Text = string.Join(", ", new string[] { txbSonhaDen.Text, txbPhuongDen.Text, txbQuanDen.Text, txbTinhDen.Text });
        }

        private void txbQuanDen_TextChanged(object sender, EventArgs e)
        {
            lbDestinationAddress.Text = string.Join(", ", new string[] { txbSonhaDen.Text, txbPhuongDen.Text, txbQuanDen.Text, txbTinhDen.Text });
        }

        private void txbTinhDen_TextChanged(object sender, EventArgs e)
        {
            lbDestinationAddress.Text = string.Join(", ", new string[] { txbSonhaDen.Text, txbPhuongDen.Text, txbQuanDen.Text, txbTinhDen.Text });
        }
    }
}