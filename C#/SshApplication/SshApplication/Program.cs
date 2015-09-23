using System;
using System.Collections.Generic;
using Renci.SshNet; /* reference needed: Renci.SshNet.dll */

class Program
{
	static void Main(string[] args)
	{

		// Setup Credentials and Server Information
		ConnectionInfo ConnNfo = new ConnectionInfo("dan.hangone.co.za", 224, "Dan",
			new AuthenticationMethod[]{

                // Pasword based Authentication
                new PasswordAuthenticationMethod("Dan","letmein5")/*,

                // Key Based Authentication (using keys in OpenSSH Format)
                new PrivateKeyAuthenticationMethod("username",new PrivateKeyFile[]{ 
                    new PrivateKeyFile(@"..\openssh.key","passphrase")
                }),*/
            }
		);
		/*
		// Execute a (SHELL) Command - prepare upload directory
		using (var sshclient = new SshClient(ConnNfo))
		{
			sshclient.Connect();
			using (var cmd = sshclient.CreateCommand("mkdir -p /tmp/uploadtest && chmod +rw /tmp/uploadtest"))
			{
				cmd.Execute();
				Console.WriteLine("Command>" + cmd.CommandText);
				Console.WriteLine("Return Value = {0}", cmd.ExitStatus);
			}
			sshclient.Disconnect();
		}
		*/

		/*
		// Upload A File
		using (var sftp = new SftpClient(ConnNfo))
		{
			string uploadfn = "Renci.SshNet.dll";

			sftp.Connect();
			sftp.ChangeDirectory("/tmp/uploadtest");
			using (var uplfileStream = System.IO.File.OpenRead(uploadfn))
			{
				sftp.UploadFile(uplfileStream, uploadfn, true);
			}
			sftp.Disconnect();
		}
		*/
		// Execute (SHELL) Commands
		using (var sshclient = new SshClient(ConnNfo))
		{
			sshclient.Connect();

			// quick way to use ist, but not best practice - SshCommand is not Disposed, ExitStatus not checked...
			Console.WriteLine(sshclient.CreateCommand("/log print").Execute());
			Console.WriteLine(sshclient.CreateCommand("/int print").Execute());
			Console.WriteLine(sshclient.CreateCommand("/ppp secret print").Execute());
			sshclient.Disconnect();
		}
		Console.ReadKey();
	}
}