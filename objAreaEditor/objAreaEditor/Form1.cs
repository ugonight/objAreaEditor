using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DxLibDLL;

namespace objAreaEditor
{
    public partial class Form1 : Form
    {
        private struct Image
        {
            public string name;
            public int handle;
            public int x, y;
        }

        private struct Area {
            public Rectangle rect;
        }

        
        private int mX, mY;             // カーソル位置（クライアント座標）
        private List<Image> mImages;    // 画像リスト
        private List<Area> mAreas;      // エリアリスト
        private Rectangle mFrame;       // 選択枠
        private Point mSp;              // ドラッグ開始座標
        private bool mDrag = false;     // ドラッグ中か
        private bool mDrawArea = false; // エリアを描いているか
        private bool[] mEditArea;       // エリアの大きさを編集しているか

        public Form1()
        {
            InitializeComponent();
            //this.ClientSize = new Size(854, 480);
            DX.SetUserWindow(pictureBox1.Handle); //DxLibの親ウインドウをこのフォームウインドウにセット
            DX.SetGraphMode(854, 480, 16);
            DX.DxLib_Init();
            DX.SetDrawScreen(DX.DX_SCREEN_BACK);

            mImages = new List<Image>();
            mAreas = new List<Area>();
            mFrame = new Rectangle(0, 0, 0, 0);
            mEditArea = new bool[4] { false, false, false, false };
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DX.DxLib_End();
        }

        public void MainLoop()
        {
            //ループする関数
            //描画、FPS管理等ここで

            // 画像描画

            Image image;
            for (int i = mImages.Count - 1; i >= 0; i--)
            {
                image = mImages[i];
                DX.DrawGraph(image.x, image.y, image.handle, 1);
            }

            // エリア描画
            DX.SetDrawBlendMode(DX.DX_BLENDMODE_ALPHA, 128);
            foreach (var area in mAreas)
            {
                DX.DrawBox(area.rect.X, area.rect.Y, area.rect.X + area.rect.Width, area.rect.Y + area.rect.Height, DX.GetColor(255, 0, 0), 1);
            }
            DX.SetDrawBlendMode(DX.DX_BLENDMODE_NOBLEND, 0);

            // 枠描画
            if (mEditArea[0] || mEditArea[1] || mEditArea[2] || mEditArea[3])
            {
                int x = mFrame.X, y = mFrame.Y, x2 = mFrame.X + mFrame.Width, y2 = mFrame.Y + mFrame.Height;
                // 左
                if (mEditArea[0]) x = mX;
                // 右
                if (mEditArea[1]) x2 = mX;
                // 上
                if (mEditArea[2]) y = mY;
                // 下
                if (mEditArea[3]) y2 = mY;

                DX.DrawBox(x, y, x2, y2, DX.GetColor(0, 255, 0), 0);
            }
            else
            if (mDrag)
            {
                int dx = mX - mSp.X, dy = mY - mSp.Y;
                DX.DrawBox(mFrame.X + dx, mFrame.Y + dy, mFrame.X + mFrame.Width + dx, mFrame.Y + mFrame.Height + dy, DX.GetColor(0, 255, 0), 0);
            }
            else
            {
                DX.DrawBox(mFrame.X, mFrame.Y, mFrame.X + mFrame.Width, mFrame.Y + mFrame.Height, DX.GetColor(0, 255, 0), 0);
            }

            // 作成中のエリア描画
            DX.SetDrawBlendMode(DX.DX_BLENDMODE_ALPHA, 128);
            if (mDrawArea)
            {
                DX.DrawBox(mSp.X, mSp.Y, mX, mY, DX.GetColor(255, 50, 50), 1);
            }
            DX.SetDrawBlendMode(DX.DX_BLENDMODE_NOBLEND, 0);

        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //フォーム上の座標でマウスポインタの位置を取得する
            //画面座標でマウスポインタの位置を取得する
            System.Drawing.Point sp = System.Windows.Forms.Cursor.Position;
            //画面座標をクライアント座標に変換する
            System.Drawing.Point cp = pictureBox1.PointToClient(sp);

            mX = cp.X;mY = cp.Y;
            toolStripStatusLabel1.Text = string.Format("{0},{1}", mX, mY);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mSp.X = mX;
            mSp.Y = mY;

            // エリア拡張
            if (tabControl1.SelectedTab == tabArea)
            {
                const int er = 3;   // 有効範囲
                // 左
                if (Math.Abs(mX - mFrame.X) <= er) mEditArea[0] = true;
                // 右
                if (Math.Abs(mX - (mFrame.X + mFrame.Width)) <= er) mEditArea[1] = true;
                // 上
                if (Math.Abs(mY - mFrame.Y) <= er) mEditArea[2] = true;
                // 下
                if (Math.Abs(mY - (mFrame.Y + mFrame.Height)) <= er) mEditArea[3] = true;
            }
            if (mEditArea[0] || mEditArea[1] || mEditArea[2] || mEditArea[3])
            {
                return;
            }


            if (mFrame.Contains(mX, mY))    // 選択されているものをドラッグ開始（画像・エリア共通）
            {
                //mSp.X = mX;
                //mSp.Y = mY;
                mDrag = true;
            }
            else    // 選択されてないけどクリックした位置にあるものを移動開始
            {
                if (tabControl1.SelectedTab == tabImage)
                {
                    int w = 0, h = 0, i = 0;
                    foreach (var image in mImages)
                    {
                        DX.GetGraphSize(image.handle, out w, out h);
                        if (new Rectangle(image.x, image.y, w, h).Contains(mX, mY))
                        {
                            //mSp.X = mX;
                            //mSp.Y = mY;
                            mDrag = true;
                            listImage.SelectedIndex = i;
                            break;
                        }
                        i++;
                    }
                }else
                if (tabControl1.SelectedTab == tabArea)
                {
                    int i = 0;
                    foreach (var area in mAreas)
                    {
                        if (area.rect.Contains(mX, mY))
                        {
                            //mSp.X = mX;
                            //mSp.Y = mY;
                            mDrag = true;
                            listArea.SelectedIndex = i;
                            return;
                        }
                        i++;
                    }

                    //mSp.X = mX;
                    //mSp.Y = mY;
                    mDrawArea = true;
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            // エリア拡張
            if (mEditArea[0] || mEditArea[1] || mEditArea[2] || mEditArea[3])
            {
                int x = mFrame.X, y = mFrame.Y, x2 = mFrame.X + mFrame.Width, y2 = mFrame.Y + mFrame.Height;
                // 左
                if (mEditArea[0]) x = mX;
                // 右
                if (mEditArea[1]) x2 = mX;
                // 上
                if (mEditArea[2]) y = mY;
                // 下
                if (mEditArea[3]) y2 = mY;

                var area = mAreas[listArea.SelectedIndex];
                area.rect.X = x;
                area.rect.Y = y;
                area.rect.Width = x2 - x;
                area.rect.Height = y2 - y;
                mAreas[listArea.SelectedIndex] = area;
                syncTab(1);
            } else

            if (mDrag)
            {
                if (tabControl1.SelectedTab == tabImage && listImage.SelectedIndex >= 0)
                {
                    int dx = mX - mSp.X, dy = mY - mSp.Y;
                    var img = mImages[listImage.SelectedIndex];
                    img.x = mFrame.X + dx; img.y = mFrame.Y + dy;
                    mImages[listImage.SelectedIndex] = img;
                    syncTab(0);
                } else if (tabControl1.SelectedTab == tabArea && listArea.SelectedIndex >= 0)
                {
                    int dx = mX - mSp.X, dy = mY - mSp.Y;
                    var area = mAreas[listArea.SelectedIndex];
                    area.rect.X += dx;
                    area.rect.Y += dy;
                    mAreas[listArea.SelectedIndex] = area;
                    syncTab(1);
                }
            }
            else
            {
                if (mDrawArea && mX != mSp.X && mY != mSp.Y)
                {
                    mAreas.Add(new Area { rect = new Rectangle(mSp, new Size(mX - mSp.X, mY - mSp.Y)) });
                    syncAreaList();
                }
            }


            mDrag = false;
            mDrawArea = false;
            mEditArea = new bool[4] { false, false, false, false };
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "画像ファイル(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png|すべてのファイル(*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.Title = "開くファイルを選択してください";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                mImages.Insert(0,new Image { name = ofd.FileName, handle = DX.LoadGraph(ofd.FileName), x = 0, y = 0 });
                syncImageList();
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            mImages.RemoveAt(listImage.SelectedIndex);
            syncImageList();
            mFrame = new Rectangle(0, 0, 0, 0);
        }

        private void btnUpImage_Click(object sender, EventArgs e)
        {
            if (listImage.SelectedIndex > 0)
            {
                int id = listImage.SelectedIndex;
                var img = mImages[id-1];
                mImages[id-1] = mImages[id];
                mImages[id] = img;
                syncImageList();
                listImage.SetSelected(id - 1, true);
            }
        }

        private void btnDownImage_Click(object sender, EventArgs e)
        {
            if (listImage.SelectedIndex >= 0 && listImage.SelectedIndex < listImage.Items.Count - 1)
            {
                int id = listImage.SelectedIndex;
                var img = mImages[id + 1];
                mImages[id + 1] = mImages[id];
                mImages[id] = img;
                syncImageList();
                listImage.SetSelected(id + 1, true);
            }
        }

        private void listImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabImage;
            syncTab(0);
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            if (listImage.SelectedIndex >= 0)
            {
                //OpenFileDialogクラスのインスタンスを作成
                OpenFileDialog ofd = new OpenFileDialog();

                ofd.Filter = "画像ファイル(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png|すべてのファイル(*.*)|*.*";
                ofd.FilterIndex = 2;
                ofd.Title = "開くファイルを選択してください";
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    tbImageName.Text = System.IO.Path.GetFileName(ofd.FileName);

                    // 画像変更
                    var id = listImage.SelectedIndex;
                    var img = mImages[id];
                    img.name = ofd.FileName;
                    DX.DeleteGraph(img.handle);
                    img.handle = DX.LoadGraph(img.name);
                    mImages[id] = img;
                    syncImageList();
                    listImage.SelectedIndex = id;
                    syncFrame(0);
                }
            }
        }

        private void nudImageX_ValueChanged(object sender, EventArgs e)
        {
            if (listImage.SelectedIndex >= 0)
            {
                // 値変更
                var img = mImages[listImage.SelectedIndex];
                img.x = (int)((NumericUpDown)sender).Value;
                mImages[listImage.SelectedIndex] = img;

                syncFrame(0);
            }
        }

        private void nudImageY_ValueChanged(object sender, EventArgs e)
        {
            if (listImage.SelectedIndex >= 0)
            {
                // 値変更
                var img = mImages[listImage.SelectedIndex];
                img.y = (int)((NumericUpDown)sender).Value;
                mImages[listImage.SelectedIndex] = img;

                syncFrame(0);
            }
        }

        private void listArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabArea;
            syncTab(1);
        }

        private void btnAddArea_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.ShowDialog(this);
            form2.Dispose();
        }

        public void addArea(int x, int y, int w, int h)
        {
            mAreas.Add(new Area { rect = new Rectangle(x, y, w, h) });
            syncAreaList();
        }

        private void btnRemoveArea_Click(object sender, EventArgs e)
        {
            mAreas.RemoveAt(listArea.SelectedIndex);
            syncAreaList();
            mFrame = new Rectangle(0, 0, 0, 0);
        }

        private void nudAreaX_ValueChanged(object sender, EventArgs e)
        {
            if (listArea.SelectedIndex >= 0)
            {
                // 値変更
                var area = mAreas[listArea.SelectedIndex];
                area.rect.X = (int)((NumericUpDown)sender).Value;
                mAreas[listArea.SelectedIndex] = area;
                syncFrame(1);
            }
        }

        private void nudAreaY_ValueChanged(object sender, EventArgs e)
        {
            if (listArea.SelectedIndex >= 0)
            {
                // 値変更
                var area = mAreas[listArea.SelectedIndex];
                area.rect.Y = (int)((NumericUpDown)sender).Value;
                mAreas[listArea.SelectedIndex] = area;
                syncFrame(1);
            }
        }

        private void nudAreaW_ValueChanged(object sender, EventArgs e)
        {
            if (listArea.SelectedIndex >= 0)
            {
                // 値変更
                var area = mAreas[listArea.SelectedIndex];
                area.rect.Width = (int)((NumericUpDown)sender).Value;
                mAreas[listArea.SelectedIndex] = area;
                syncFrame(1);
            }
        }

        private void nudAreaH_ValueChanged(object sender, EventArgs e)
        {
            if (listArea.SelectedIndex >= 0)
            {
                // 値変更
                var area = mAreas[listArea.SelectedIndex];
                area.rect.Height = (int)((NumericUpDown)sender).Value;
                mAreas[listArea.SelectedIndex] = area;
                syncFrame(1);
            }
        }


        // リストをコントロールに反映させる
        private void syncImageList()
        {
            listImage.Items.Clear();
            foreach(var image in mImages)
            {
                listImage.Items.Add(System.IO.Path.GetFileName(image.name));
            }
        }

        // リストをコントロールに反映させる
        private void syncAreaList()
        {
            listArea.Items.Clear();
            foreach (var area in mAreas)
            {
                listArea.Items.Add(string.Format("{0},{1},{2},{3}", area.rect.X, area.rect.Y, area.rect.Width, area.rect.Height));
            }
        }

        // 枠を更新(0:画像 1:エリア)
        private void syncFrame(int mode)
        {
            int w, h;
            if (mode == 0)
            {
                DX.GetGraphSize(mImages[listImage.SelectedIndex].handle, out w, out h);
                mFrame = new Rectangle(mImages[listImage.SelectedIndex].x, mImages[listImage.SelectedIndex].y, w, h);
            }
            else
            {
                mFrame = mAreas[listArea.SelectedIndex].rect;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mFrame = new Rectangle(0, 0, 0, 0);
        }

        private void listImage_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listImage_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileNames =
        (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int ihandle;
            foreach (var fileName in fileNames)
            {
                ihandle = DX.LoadGraph(fileName);
                if (ihandle >= 0)
                    mImages.Insert(0, new Image { name = fileName, handle = ihandle, x = 0, y = 0 });
            }
        
            syncImageList();
        }


        // タブの項目を更新
        private void syncTab(int mode)
        {
            if (mode == 0)
            {
                if (tabControl1.SelectedTab == tabImage && listImage.SelectedIndex >= 0)
                {
                    tbImageName.Text = System.IO.Path.GetFileName(mImages[listImage.SelectedIndex].name);
                    nudImageX.Value = mImages[listImage.SelectedIndex].x;
                    nudImageY.Value = mImages[listImage.SelectedIndex].y;

                    int w, h;
                    DX.GetGraphSize(mImages[listImage.SelectedIndex].handle, out w, out h);
                    labelImageCenter.Text = string.Format("{0},{1}", mImages[listImage.SelectedIndex].x + w / 2, mImages[listImage.SelectedIndex].y + h / 2);

                    syncFrame(0);
                }
            }
            else
            {
                if (tabControl1.SelectedTab == tabArea && listArea.SelectedIndex >= 0)
                {
                    nudAreaX.Value = mAreas[listArea.SelectedIndex].rect.X;
                    nudAreaY.Value = mAreas[listArea.SelectedIndex].rect.Y;
                    nudAreaW.Value = mAreas[listArea.SelectedIndex].rect.Width;
                    nudAreaH.Value = mAreas[listArea.SelectedIndex].rect.Height;

                    syncFrame(1);
                }
            }
        }
    }
}
