
using Microsoft.Extensions.Configuration;
using OpenAI;
using OpenAI.Chat;
using System.ClientModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text;


namespace TQMathphix
{
    public partial class frmMain : Form
    {
        ChatClient client;
        public frmMain()
        {
            InitializeComponent();

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var agentConfig = configuration.GetSection("Ollama");
            Keys.BASE_URL = agentConfig.GetSection("OLLAMA_BASE_URL").Value ?? "http://localhost:11434/v1";
            Keys.MODEL = agentConfig.GetSection("OLLAMA_MODEL").Value ?? "glm-ocr";
            try
            {
                client = new(
                 model: Keys.MODEL,
                 credential: new ApiKeyCredential(Keys.APIKEY),
                 options: new OpenAIClientOptions()
                 {
                     Endpoint = new Uri(Keys.BASE_URL)
                 });
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message+":The System will be Terminated!");
                Application.Exit();
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!validate()) return;
            this.richTextBox2.Text = string.Empty;
            byte[] data = ImageToByteArray(pictureBox1);           

            
            List<ChatMessage> messages =
            [
                new UserChatMessage(
                    ChatMessageContentPart.CreateTextPart(this.richTextBox1.Text.Trim()),
                    ChatMessageContentPart.CreateImagePart(new BinaryData(data), "image/png")),
            ];

            try
            {

                ChatCompletion completion = await client.CompleteChatAsync(messages);
                this.richTextBox2.Text = completion.Content[0].Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.richTextBox2.Text);
        }

        private void PasteImageFromClipboard()
        {

            this.richTextBox2.Text = string.Empty;
            try
            {
                // 检查剪贴板是否包含图像数据
                if (Clipboard.ContainsImage())
                {
                    // 获取剪贴板图像并赋值给 PictureBox
                    Image clipboardImage = Clipboard.GetImage();
                    pictureBox1.Image = clipboardImage;
                    // 自适应显示（可选）
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Refresh();
                }
                else
                {
                    MessageBox.Show("no image in clipboard！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"paste failure：{ex.Message}");
            }
        }

        public byte[] ImageToByteArray(PictureBox pictureBox)
        {
            // 校验 PictureBox 是否有图像
            if (pictureBox.Image == null)
            {
                MessageBox.Show("PictureBox has no image！");
                return null;
            }

            try
            {
                // 使用内存流转换图像
                using (MemoryStream ms = new MemoryStream())
                {
                    // 保存为 PNG 格式，可改为 ImageFormat.Jpeg/ImageFormat.Bmp 等
                    Image original = pictureBox.Image;
                    if (original.Height >= 1024)
                    {
                        Image resized = ResizeImage(original, 1024, 1024); //不溢出
                        pictureBox.Image = resized;
                    }
                    pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failure：{ex.Message}");
                return null;
            }
        }

        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, width, height);
            }
            return bmp;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            PasteImageFromClipboard();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // 只显示文本文件
                openFileDialog.Filter = "txt (*.txt)|*.txt|all files (*.*)|*.";
                openFileDialog.Title = "selected file";
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 获取选中文件路径
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        // 读取文件内容（自动处理编码，常用）
                        string content = File.ReadAllText(filePath);


                        this.richTextBox1.Text = content;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Read：" + ex.Message, "error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool validate()
        {
            if (this.pictureBox1.Image == null)
            {
                MessageBox.Show("not paste image");
                return false;
            }

            if (string.IsNullOrEmpty(this.richTextBox1.Text))
            {
                MessageBox.Show("prompts not empty");
                return false;
            }

            if (this.radioButton1.Checked)
            {
                if (!this.richTextBox1.Text.Contains("Formula Recognition"))
                {
                    MessageBox.Show("Formula Recognition Prompts error");
                    return false;
                }
            }

            if (this.radioButton2.Checked)
            {
                if (!this.richTextBox1.Text.Contains("Text Recognition"))
                {
                    MessageBox.Show("Text Recognition Prompts error");
                    return false;
                }
            }

            if (this.radioButton3.Checked)
            {
                if (!this.richTextBox1.Text.Contains("Table Recognition"))
                {
                    MessageBox.Show("Table Recognition Prompts error");
                    return false;
                }
            }

            return true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = string.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // 只显示文本文件
                openFileDialog.Filter = "jpg (*.jpg)|*.jpg|png (*.png)|*.png";
                openFileDialog.Title = "selected image file";
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                     
                    string filePath = openFileDialog.FileName;

                    this.pictureBox1.ImageLocation = filePath;
                }
            }
        }
    }
}
