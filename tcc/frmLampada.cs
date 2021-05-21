using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace tcc
{
    public partial class frmLampada : Form
    {
        private List<Image> LoadedImages { get; set; }
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice VideoDevices;
        public frmLampada()
        {
            InitializeComponent();
            getallcameralist();
        }
        private void frmVideo_Load(object sender, EventArgs e)
        {

        }
        void getallcameralist()
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Devices in CaptureDevice)
            {
                cbCamera.Items.Add(Devices.Name);
            }
        }
        private void NewVideoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picVideo.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void btnStart_Click_1(object sender, EventArgs e)
        {
            EncerrarWebcam();
            try
            {
                VideoDevices = new VideoCaptureDevice(CaptureDevice[cbCamera.SelectedIndex].MonikerString);
                VideoDevices.NewFrame += new NewFrameEventHandler(NewVideoFrame);
                VideoDevices.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadImagesFromFolder()
        {
            string[] arquivos = Directory.GetFiles(@"C:\Users\fabio\Desktop\imagens\");
            LoadedImages = new List<Image>();
            foreach (var item in arquivos)
            {
                var tempImage = Image.FromFile(item);
                LoadedImages.Add(tempImage);
            }
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            //salvar
            string caminho = @"C:\Users\fabio\Desktop\imagens\" + DateTime.Now.Day.ToString() +
            DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Minute.ToString()
            + DateTime.Now.Second.ToString() + ".jpg";
            picFotos.Image = (Bitmap)picVideo.Image.Clone();
            picFotos.Image.Save(caminho, ImageFormat.Jpeg);

            imageList.Clear();
            //carregando imagens da pasta
            LoadImagesFromFolder();

            //inicializando lista de imagens
            ImageList images2 = new ImageList();
            images2.ImageSize = new Size(130, 40);

            foreach (var image in LoadedImages)
            {
                images2.Images.Add(image);
            }

            //configurando nossa listview com imageList
            imageList.LargeImageList = images2;

            for (int itemIndex = 1; itemIndex <= LoadedImages.Count; itemIndex++)
            {
                imageList.Items.Add(new ListViewItem($"Imagem {itemIndex}", itemIndex - 1));
            }
        }

        private void btnImagem_Click_1(object sender, EventArgs e)
        {
            imageList.Clear();
            //carregando imagens da pasta
            LoadImagesFromFolder();

            //inicializando lista de imagens
            ImageList images = new ImageList();
            images.ImageSize = new Size(130, 40);

            foreach (var image in LoadedImages)
            {
                images.Images.Add(image);
            }

            //configurando nossa listview com imageList
            imageList.LargeImageList = images;

            for (int itemIndex = 1; itemIndex <= LoadedImages.Count; itemIndex++)
            {
                imageList.Items.Add(new ListViewItem($"Imagem {itemIndex}", itemIndex - 1));
            }
        }
        private void EncerrarWebcam()
        {
            if (VideoDevices != null && VideoDevices.IsRunning)
            {
                VideoDevices.SignalToStop();
                VideoDevices = null;
            }
        }
        private void cbCamera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmLampada_FormClosed(object sender, FormClosedEventArgs e)
        {
            EncerrarWebcam();
        }

        private void imageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imageList.SelectedIndices.Count > 0)
            {
                var selectedIndex = imageList.SelectedIndices[0];
                Image selectedImg = LoadedImages[selectedIndex];
                picFotos.Image = selectedImg;
            }
        }
    }
}
