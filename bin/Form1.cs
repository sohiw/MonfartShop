using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telegram;

namespace bot
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Telegram.bot.token = " enter token here ";
            CheckForIllegalCrossThreadCalls = false;
            backgroundWorker1.RunWorkerAsync();
        }
        int r = 1;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            while (true)
            {
                string gem = "0";
                string admin_id = "363232437, 328567398";
                Telegram.bot.update = "True";
                textBox1.Text = Telegram.bot.update;
                if (Telegram.bot.message_text == "/start")
                {
                    Telegram.bot.send_inline_keyboard.keyboard_R1_1 = "ورود به فروشگاه";
                    Telegram.bot.send_inline_keyboard.keyboard_R1_1_callback_data = "buy";
                    Telegram.bot.send_inline_keyboard.send(Telegram.bot.chat_id, "یکی از دکمه های زیر رو انتخاب کنید");
                }
                if (Telegram.bot.message_text == "/start" & Telegram.bot.chat_id == admin_id)
                {
                    Telegram.bot.send_inline_keyboard.keyboard_R1_1 = "امار ربات";
                    Telegram.bot.send_inline_keyboard.keyboard_R1_1_callback_data = "amar";
                    Telegram.bot.send_inline_keyboard.keyboard_R1_2 = "ارسال پیام به همه";
                    Telegram.bot.send_inline_keyboard.keyboard_R1_2_callback_data = "toall";
                    Telegram.bot.send_inline_keyboard.send(admin_id, "سلام خوش اومدی به بخش مدیریت\n\nیکی از دکمه های زیر و انتخاب کن");

                }
                if (Telegram.bot.data == "cr")
                {
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1 = "بازگشت";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1_callback_data = "start";
                    Telegram.bot.editMessageInlinekeyboard.send(Telegram.bot.chat_id, Telegram.bot.message_id, "سازنده من : @monfar");
                }
                if (Telegram.bot.data == "ch")
                {
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1 = "بازگشت";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1_callback_data = "start";
                    Telegram.bot.editMessageInlinekeyboard.send(Telegram.bot.chat_id, Telegram.bot.message_id, "کانال پشتیبانی : @devof");
                }
                if (Telegram.bot.data == "start")
                {
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1 = "ورود به فروشگاه";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1_callback_data = "buy";
                    Telegram.bot.editMessageInlinekeyboard.send(Telegram.bot.chat_id, Telegram.bot.message_id, "یکی از دکمه های زیر رو انتخاب کنید");
                }
                if (Telegram.bot.data == "buy")
                {
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1 = " تبچی api";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1_callback_data = "tabchi";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_2 = " پیام رسان ";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_2_callback_data = "pvresan";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R2_1 = "سورس این ربات";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R2_1_callback_data = "thisbot";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R2_2 = "خرید اموزش telegram.dll";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R2_2_callback_data = "dll";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R3_1 = "چنل ما";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R3_2 = "سازنده";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R3_1_callback_data = "ch";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R3_2_callback_data = "cr";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R4_2 = "الماس های شما";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R4_2_callback_data = "almas";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R4_3 = "بازگشت";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R4_3_callback_data = "start";
                    Telegram.bot.editMessageInlinekeyboard.send(Telegram.bot.chat_id, Telegram.bot.message_id, "یکی از دکمه های زیر را برای خریئ انتخاب کنید و بر رویش کلیک کنید");

                }
                if (Telegram.bot.data == "tabchi")
                {
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1 = "بازگشت";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1_callback_data = "start";
                    Telegram.bot.editMessageInlinekeyboard.send(Telegram.bot.chat_id, Telegram.bot.message_id, "خرید سورس انتخاب شد\n\nبرای خرید با شارژ همراه اول یا ایرانسل به ایدی زیر مراجعه کنید\n\n@monfar\n\nیا الماس بخرید تمامی سورس ها 200 الماس هستند");

                }
                if (Telegram.bot.data == "pvresan")
                {
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1 = "بازگشت";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1_callback_data = "start";
                    Telegram.bot.editMessageInlinekeyboard.send(Telegram.bot.chat_id, Telegram.bot.message_id, "خرید سورس انتخاب شد\n\nبرای خرید با شارژ همراه اول یا ایرانسل به ایدی زیر مراجعه کنید\n\n@monfar\n\nیا الماس بخرید تمامی سورس ها 200 الماس هستند");
                }
                if (Telegram.bot.data == "thisbot")
                {
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1 = "بازگشت";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1_callback_data = "start";
                    Telegram.bot.editMessageInlinekeyboard.send(Telegram.bot.chat_id, Telegram.bot.message_id, "خرید سورس انتخاب شد\n\nبرای خرید با شارژ همراه اول یا ایرانسل به ایدی زیر مراجعه کنید\n\n@monfar\n\nیا الماس بخرید تمامی سورس ها 200 الماس هستند");

                }
                if (Telegram.bot.data == "dll")
                {
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1 = "بازگشت";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1_callback_data = "start";
                    Telegram.bot.editMessageInlinekeyboard.send(Telegram.bot.chat_id, Telegram.bot.message_id, "خرید سورس انتخاب شد\n\nبرای خرید با شارژ همراه اول یا ایرانسل به ایدی زیر مراجعه کنید\n\n@monfar\n\nیا الماس بخرید تمامی سورس ها 200 الماس هستند");
                }
                if (Telegram.bot.data == "almas")
                {
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1 = "خرید الماس";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1_callback_data = "buygem";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_2 = "برگشت";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_2_callback_data = "start";
                    Telegram.bot.editMessageInlinekeyboard.send(Telegram.bot.chat_id, Telegram.bot.message_id, "تعداد الماس های شما :\n" + gem);

                }
                if (Telegram.bot.data == "buygem")
                {
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1 = "برای خرید 20 الماس به قیمت 5000 تومان  کلیک کنید";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1_Url = "ppng.ir/d/nE9I";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R2_1 = "بازگشت";
                    Telegram.bot.editMessageInlinekeyboard.keyboard_R2_1_callback_data = "start";
                    Telegram.bot.editMessageInlinekeyboard.send(Telegram.bot.chat_id, Telegram.bot.message_id, "یکی از دکمه های زیر را انتخاب کنید :)");

                }

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = Telegram.bot.update;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("created by @monfar");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThreadStart ts = new ThreadStart(sohiw);
            Thread TRD = new Thread(ts);
            TRD.Start();
        }
        private void sohiw()
        {
            int t = 2000;
            while (true)
            {
                textBox2.Text = r++.ToString();
                Thread.Sleep(50);
            }
        }
    }
}

    


