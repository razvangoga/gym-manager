using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

using MyControls.WindowsControls;

namespace MyControls.Logic
{
    public static class MessageStripFormatting
    {
        /// <summary>
        /// static method for formating a toolstrip status label with default values
        /// </summary>
        /// <param name="label">tool strip label afected</param>
        public static void setMessageStrip(ToolStripStatusLabel label)
        {
            label.Text = string.Empty;
            label.BackColor = Color.LightBlue;
            label.ForeColor = Color.Navy;
        }

        /// <summary>
        /// static method for formating a toolstrip status label with text and default colors
        /// </summary>
        /// <param name="sMesaj">tool strip text</param>
        /// <param name="label">tool strip label afected</param>
        public static void setMessageStrip(string sMesaj, ToolStripStatusLabel label)
        {
            label.Text = sMesaj;
            label.BackColor = Color.LightBlue;
            label.ForeColor = Color.Navy;
        }

        /// <summary>
        /// static method for formating a toolstrip status label
        /// </summary>
        /// <param name="Mesaj">tool strip text</param>
        /// <param name="BackColor">background color</param>
        /// <param name="TextColor">text color</param>
        /// <param name="label">tool strip label afected</param>
        public static void setMessageStrip(string sMesaj, Color colBackColor, Color colTextColor, ToolStripStatusLabel label)
        {
            label.BackColor = colBackColor;
            label.ForeColor = colTextColor;
            label.Text = sMesaj;
        }

        /// <summary>
        /// static method for formating a toolstrip label with default values
        /// </summary>
        /// <param name="label">tool strip label afected</param>
        public static void setMessageStrip(ToolStripLabel label)
        {
            label.Text = string.Empty;
            label.BackColor = Color.LightBlue;
            label.ForeColor = Color.Navy;
        }

        /// <summary>
        /// static method for formating a toolstrip label with text and default colors
        /// </summary>
        /// <param name="sMesaj">tool strip text</param>
        /// <param name="label">tool strip label afected</param>
        public static void setMessageStrip(string sMesaj, ToolStripLabel label)
        {
            label.Text = sMesaj;
            label.BackColor = Color.LightBlue;
            label.ForeColor = Color.Navy;
        }

        /// <summary>
        /// static method for formating a toolstrip label
        /// </summary>
        /// <param name="Mesaj">tool strip text</param>
        /// <param name="BackColor">background color</param>
        /// <param name="TextColor">text color</param>
        /// <param name="label">tool strip label afected</param>
        public static void setMessageStrip(string sMesaj, Color colBackColor, Color colTextColor, ToolStripLabel label)
        {
            label.BackColor = colBackColor;
            label.ForeColor = colTextColor;
            label.Text = sMesaj;
        }

        /// <summary>
        /// static method for formating a label with default values
        /// </summary>
        /// <param name="label">label afected</param>
        public static void setMessageStrip(Label label)
        {
            label.Text = string.Empty;
            label.BackColor = Color.LightBlue;
            label.ForeColor = Color.Navy;
        }

        /// <summary>
        /// static method for formating a label with text and default colors
        /// </summary>
        /// <param name="sMesaj">label text</param>
        /// <param name="label">label afected</param>
        public static void setMessageStrip(string sMesaj, Label label)
        {
            label.Text = sMesaj;
            label.BackColor = Color.LightBlue;
            label.ForeColor = Color.Navy;
        }

        /// <summary>
        /// static method for formating a label
        /// </summary>
        /// <param name="Mesaj">text</param>
        /// <param name="BackColor">background color</param>
        /// <param name="TextColor">text color</param>
        /// <param name="label">label afected</param>
        public static void setMessageStrip(string sMesaj, Color colBackColor, Color colTextColor, Label label)
        {
            label.BackColor = colBackColor;
            label.ForeColor = colTextColor;
            label.Text = sMesaj;
        }

        /// <summary>
        /// static method for formatting a label using a custom format
        /// </summary>
        /// <param name="label">affected label</param>
        /// <param name="sMesaj">text message</param>
        /// <param name="messageType">custom message type</param>
        public static void setMessageStripCustomMessage(Label label, string sMesaj, MessageType messageType)
        {
            label.Text = sMesaj;

            switch (messageType)
            {
                case MessageType.Error :
                    {
                        label.BackColor = Color.Red;
                        label.ForeColor = Color.White;
                        break;
                    }
                case MessageType.Message:
                    {
                        label.BackColor = Color.LightBlue;
                        label.ForeColor = Color.Black;
                        break;
                    }
                case MessageType.Ok :
                    {
                        label.BackColor = Color.Green;
                        label.ForeColor = Color.White;
                        break;
                    }
                case MessageType.Warrning :
                    {
                        label.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                        label.ForeColor = Color.Black;
                        break;
                    }
                default:
                    {
                        label.BackColor = Color.LightBlue;
                        label.ForeColor = Color.Black;
                        break;
                    }
            }
        }

        /// <summary>
        /// static method for formatting a label using a custom format
        /// </summary>
        /// <param name="label">affected label</param>
        /// <param name="sMesaj">text message</param>
        /// <param name="messageType">custom message type</param>
        public static void setMessageStripCustomMessage(ToolStripLabel label, string sMesaj, MessageType messageType)
        {
            label.Text = sMesaj;

            switch (messageType)
            {
                case MessageType.Error:
                    {
                        label.BackColor = Color.Red;
                        label.ForeColor = Color.White;
                        break;
                    }
                case MessageType.Message:
                    {
                        label.BackColor = Color.LightBlue;
                        label.ForeColor = Color.Black;
                        break;
                    }
                case MessageType.Ok:
                    {
                        label.BackColor = Color.Green;
                        label.ForeColor = Color.White;
                        break;
                    }
                case MessageType.Warrning:
                    {
                        label.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                        label.ForeColor = Color.Black;
                        break;
                    }
                default:
                    {
                        label.BackColor = Color.LightBlue;
                        label.ForeColor = Color.Black;
                        break;
                    }
            }
        }

        /// <summary>
        /// static method for formatting a label using a custom format
        /// </summary>
        /// <param name="label">affected label</param>
        /// <param name="sMesaj">text message</param>
        /// <param name="messageType">custom message type</param>
        public static void setMessageStripCustomMessage(ToolStripStatusLabel label, string sMesaj, MessageType messageType)
        {
            label.Text = sMesaj;

            switch (messageType)
            {
                case MessageType.Error:
                    {
                        label.BackColor = Color.Red;
                        label.ForeColor = Color.White;
                        break;
                    }
                case MessageType.Message:
                    {
                        label.BackColor = Color.LightBlue;
                        label.ForeColor = Color.Black;
                        break;
                    }
                case MessageType.Ok:
                    {
                        label.BackColor = Color.Green;
                        label.ForeColor = Color.White;
                        break;
                    }
                case MessageType.Warrning:
                    {
                        label.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                        label.ForeColor = Color.Black;
                        break;
                    }
                default:
                    {
                        label.BackColor = Color.LightBlue;
                        label.ForeColor = Color.Black;
                        break;
                    }
            }
        }
    }

    public enum MessageType
    {
        Error,
        Message,
        Ok,
        Warrning
    }
}
