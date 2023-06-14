string connetionString = null;
MySqlConnection cnn;
connetionString = "server=localhost;database=school;uid=root;pwd=\"\";";
cnn = new MySqlConnection(connetionString);
try
{
    cnn.Open();
    MessageBox.Show("Connection Open ! ");
    cnn.Close();
}
catch (Exception ex)
{
    MessageBox.Show("Can not open connection ! ");
}