using System;

using System.ComponentModel;

using System.Threading.Tasks;

using System.Windows.Forms;

 

namespace WindowsFormsApplication1

{

public partial class Form1 : Form

{

public Form1()

{

InitializeComponent();

}

public Task LongProcess()

{

return Task.Run(() => {

System.Threading.Thread.Sleep(5000);

});

}

public async Task CallProcess()

{

await LongProcess();

this.listBox1.Items.Add("Long Finish");

}

private void Form1_Load(object sender, EventArgs e)

{

}

private void button1_Click(object sender, EventArgs e)

{

this.label1.Text = "Return Task";

CallProcess();

this.listBox1.Items.Add("Program Finish");

}

}

}