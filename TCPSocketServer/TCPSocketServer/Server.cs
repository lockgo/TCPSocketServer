/*
 * Created by SharpDevelop.
 * User: Crogogo
 * Date: 10/6/2019
 * Time: 10:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net.Sockets;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace TCPSocketServer
{
	/// <summary>
	/// Description of Server.
	/// </summary>
	public partial class Server : Form
	{
		
		private StreamWriter serverStreamWriter;
        private StreamReader serverStreamReader;
		public Server()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private bool StartServer()
        {
            //create server's tcp listener for incoming connection
            TcpListener tcpServerListener = new TcpListener(4444);
            tcpServerListener.Start();        //start server
            Console.WriteLine("Server Started");
            this.btnStartServer.Enabled = false;
            //block tcplistener to accept incoming connection
            Socket serverSocket = tcpServerListener.AcceptSocket();
 
            try
            {
                if (serverSocket.Connected)
                {
                   Console.WriteLine("Client connected");
                   //open network stream on accepted socket
                   NetworkStream serverSockStream = 
                       new NetworkStream(serverSocket);
                   serverStreamWriter =  new StreamWriter(serverSockStream);
                   serverStreamReader =  new StreamReader(serverSockStream);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace); 
                return false;
            }
 
            return true;
        }
		
		void BtnStartServerClick(object sender, EventArgs e)
		{
			//start server
            if (!StartServer())
            {
            	Console.WriteLine("Unable to start server");
            	textBox1.Text = "Unable to start server";
            }
                
 
            //sending n receiving msgs
            while (true)
            {
                //Console.WriteLine("CLIENT: "+serverStreamReader.ReadLine());
                
                richTextBox1.Text = richTextBox1.Text + "\n" + " " + serverStreamReader.ReadLine();
                serverStreamWriter.WriteLine("Hi! " + richTextBox1.Text); 
                serverStreamWriter.Flush();
            }
		}
	}
}
