using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace lv4_oop_matos
{
    public partial class Form1 : Form
    {


        OleDbConnection myConnection;
        OleDbDataAdapter myOledbDataAdapter;

        BindingSource bsCustomer = new BindingSource();
        BindingSource bsShipper = new BindingSource();
        BindingSource bsEmployee = new BindingSource();
        BindingSource bsOrders = new BindingSource();
        BindingSource bsOrdCustEmpShip = new BindingSource();
        BindingSource bsOrdCustEmp = new BindingSource();
        BindingSource bsOrdCustShip = new BindingSource();
        BindingSource bsOrdEmpShip = new BindingSource();
        BindingSource bsSh = new BindingSource();
        BindingSource bsCust = new BindingSource();
        BindingSource bsEmp = new BindingSource();


        string myConnectionString = ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;

        string CustomerValue;
        int EmployeeValue;
        int ShipperValue;


        bool flagCustomer = false, flagShipper = false, flagEmployee = false;
        public Form1()
        {
            InitializeComponent();

        }
        //treba jos da sva tri/dva u isto vrijeme mogu i da je cijeli order da nitko nije na pocetku
        private void cBoCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            flagCustomer = true;
            if (cBoCustomer.SelectedIndex > -1)
            {
                if (cBoCustomer.SelectedValue != null) CustomerValue = Convert.ToString(cBoCustomer.SelectedValue);
                Special();
                if (flagShipper && flagEmployee)
                {
                    dataGridView1.DataSource = bsOrdCustEmpShip;
                }
                else if (flagEmployee && !flagShipper)
                {
                    dataGridView1.DataSource = bsOrdCustEmp;
                }
                else if (flagShipper && !flagEmployee)
                {
                    dataGridView1.DataSource = bsOrdCustShip;
                }
                else
                {
                   
                    dataGridView1.DataSource = bsCust;
                }
            }



        }

        private void cBoEmpyee_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s;
            flagEmployee = true;
            if (cBoEmpyee.SelectedValue != null)
            {
                s = cBoEmpyee.SelectedValue.ToString();
                Int32.TryParse(s, out EmployeeValue);

            }
            Special();
            if (flagShipper && flagCustomer)
            {
                dataGridView1.DataSource = bsOrdCustEmpShip;
            }
            else if (flagCustomer && !flagShipper)
            {
                dataGridView1.DataSource = bsOrdCustEmp;
            }
            else if (flagShipper && !flagCustomer)
            {
                dataGridView1.DataSource = bsOrdEmpShip;
            }
            else
            {
               
                dataGridView1.DataSource = bsEmp;
            }

        }

        private void cBoShipper_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s;
            flagShipper = true;
            if (cBoShipper.SelectedValue != null)
            {
                s = cBoShipper.SelectedValue.ToString();
                Int32.TryParse(s, out ShipperValue);

            }
            Special();
            if (flagCustomer && flagEmployee)
            {
                dataGridView1.DataSource = bsOrdCustEmpShip;
            }
            else if (flagEmployee && !flagCustomer)
            {
                dataGridView1.DataSource = bsOrdEmpShip;
            }
            else if (flagCustomer && !flagEmployee)
            {
                dataGridView1.DataSource = bsOrdCustShip;
            }
            else
            {
                
                dataGridView1.DataSource = bsSh;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
            dataGridView1.Columns[0].Visible = false;
        }

        private void brnChooseOption_Click(object sender, EventArgs e)
        { //koriste se nakon koritenja bar jednog filtra
            if (rBDelete.Checked)
            {
                int lblText;
                string s = lblId.Text;
                Int32.TryParse(s, out lblText);
               DialogResult result= MessageBox.Show("Are you sure you want to delete the seleted order?", "Delete order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (!String.IsNullOrEmpty(txtCustomer.Text) && !String.IsNullOrEmpty(txtEmp.Text) && !String.IsNullOrEmpty(txtShipId.Text))//provjeravamo da je korisnik unio vrijednost
                    {
                        using (myConnection = new OleDbConnection(myConnectionString))
                        {
                            myConnection.Open();
                            try //kada radimo SQL upit staviti pod try catch
                            {
                                string mySqlString = "DELETE FROM Orders WHERE OrderId=@ID";
                                OleDbCommand myCom = new OleDbCommand(mySqlString, myConnection);
                                myCom.Parameters.AddWithValue("@ID", lblId.Text);
                                myCom.ExecuteNonQuery(); //ne ocekujemo nikakvu povratnu informaciju
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                            }
                            myConnection.Close();
                        }
                        Special();//ponovno ucitava nove podatke iz baze i ponovno binda podatke u tablici Orders(početni prikaz tablice bez filtera)
                    }
                }
            }

            else if (rBInsert.Checked)
            {
                if (!String.IsNullOrEmpty(txtCustomer.Text) && !String.IsNullOrEmpty(txtEmp.Text) && !String.IsNullOrEmpty(txtFreight.Text) && !String.IsNullOrEmpty(txtShipAdd.Text) && !String.IsNullOrEmpty(txtShipCity.Text) && !String.IsNullOrEmpty(txtShipCountry.Text) &&  !String.IsNullOrEmpty(txtShipId.Text) && !String.IsNullOrEmpty(txtShipName.Text) && !String.IsNullOrEmpty(txtShipZIP.Text))//provjeravamo da je korisnik unio vrijednost
                {
                    using (myConnection = new OleDbConnection(myConnectionString))
                    {
                        myConnection.Open();
                        try //kada radimo SQL upit staviti pod try catch
                        {
                            txtOrdDate.Enabled = false;
                            txtReqDate.Enabled = false;
                            txtShipDate.Enabled = false;
                            string mySqlString = "INSERT INTO Orders(CustomerID,EmployeeID, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPOstalCode, ShipCountry) VALUES(@CustomerID, @EmployeeID, @ShipperID, @Freight, @SHNmae, @Add, @city,@region, @zip, @country)";

                            OleDbCommand myCom = new OleDbCommand(mySqlString, myConnection);
                            myCom.Parameters.AddWithValue("@CustomerID", txtCustomer.Text);
                            myCom.Parameters.AddWithValue("@EmployeeID", txtEmp.Text);
                            myCom.Parameters.AddWithValue("@ShipperID", txtShipId.Text);
                            myCom.Parameters.AddWithValue("@Freight", txtFreight.Text);
                            myCom.Parameters.AddWithValue("@SHNmae", txtShipName.Text);
                            myCom.Parameters.AddWithValue("@Add", txtShipAdd.Text);
                            myCom.Parameters.AddWithValue("@city", txtShipCity.Text);
                            myCom.Parameters.AddWithValue("@region", txtShipRegion.Text);
                            myCom.Parameters.AddWithValue("@zip", txtShipZIP.Text);
                            myCom.Parameters.AddWithValue("@country", txtShipCountry.Text);
                            myCom.ExecuteNonQuery(); //ne ocekujemo nikakvu povratnu informaciju
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                        }
                        myConnection.Close();
                    }
                    Special();
                }

                
            }
            
            else if (rBUpdate.Checked)
            {
                if (!String.IsNullOrEmpty(txtCustomer.Text) || !String.IsNullOrEmpty(txtEmp.Text) || !String.IsNullOrEmpty(txtFreight.Text) && !String.IsNullOrEmpty(txtShipAdd.Text) || !String.IsNullOrEmpty(txtShipCity.Text) || !String.IsNullOrEmpty(txtShipCountry.Text) || !String.IsNullOrEmpty(txtShipId.Text) || !String.IsNullOrEmpty(txtShipName.Text) || !String.IsNullOrEmpty(txtShipZIP.Text))//provjeravamo da je korisnik unio vrijednost
                {
                    using (myConnection = new OleDbConnection(myConnectionString))
                    {
                        myConnection.Open();
                        try //kada radimo SQL upit staviti pod try catch
                        {
                            string mySqlString = "UPDATE Orders SET CustomerID=@CustomerID,EmployeeID= @EmployeeID, ShipVia=@ShipperID, Freight=@Freight, ShipName=@SHNmae, ShipAddress=@Add, ShipCity= @city, ShipRegion=@region, ShipPOstalCode=@zip, ShipCountry= @country WHERE OrderID=@ord";

                            OleDbCommand myCom = new OleDbCommand(mySqlString, myConnection);
                            myCom.Parameters.AddWithValue("@CustomerID", txtCustomer.Text);
                            myCom.Parameters.AddWithValue("@EmployeeID", txtEmp.Text);
                            myCom.Parameters.AddWithValue("@ShipperID", txtShipId.Text);
                            myCom.Parameters.AddWithValue("@Freight", txtFreight.Text);
                            myCom.Parameters.AddWithValue("@SHNmae", txtShipName.Text);
                            myCom.Parameters.AddWithValue("@Add", txtShipAdd.Text);
                            myCom.Parameters.AddWithValue("@city", txtShipCity.Text);
                            myCom.Parameters.AddWithValue("@region", txtShipRegion.Text);
                            myCom.Parameters.AddWithValue("@zip", txtShipZIP.Text);
                            myCom.Parameters.AddWithValue("@country", txtShipCountry.Text);
                            myCom.Parameters.AddWithValue("@ord", lblId.Text);
                            myCom.ExecuteNonQuery(); //ne ocekujemo nikakvu povratnu informaciju
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                        }
                         myConnection.Close();
                    }
                    Special();
                }
            } //ponovno ucitava nove podatke iz baze i ponovno binda podatke
        }


        private void btnRemoveFilters_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        { 
            lblId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); //selected rows od nula-da može samo jedan red označiti, može i da bude više
            txtCustomer.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(); //cells pomjeramo na sljedeći stupac
            txtEmp.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtOrdDate.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtReqDate.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtShipDate.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtShipId.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtFreight.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtShipName.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtShipAdd.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtShipCity.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            txtShipRegion.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            txtShipZIP.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            txtShipCountry.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                lblId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); //selected rows od nula-da može samo jedan red označiti, može i da bude više
                txtCustomer.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(); //cells pomjeramo na sljedeći stupac
                txtEmp.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtOrdDate.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtReqDate.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtShipDate.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtShipId.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                txtFreight.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                txtShipName.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                txtShipAdd.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                txtShipCity.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                txtShipRegion.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                txtShipZIP.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                txtShipCountry.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            }
          
        }

        private void rBInsert_CheckedChanged(object sender, EventArgs e)
        {
            lblId.Text = "";
            txtOrdDate.Clear();
            txtReqDate.Clear();
            txtShipDate.Clear();
            txtOrdDate.Enabled = false;
            txtReqDate.Enabled = false;
            txtShipDate.Enabled = false;
            txtShipAdd.Clear();
            txtCustomer.Clear();
            txtShipCountry.Clear();
            txtShipId.Clear();
            txtShipName.Clear();
            txtShipRegion.Clear();
            txtShipZIP.Clear();
            txtFreight.Clear();
            txtEmp.Clear();
            txtShipCity.Clear();
        }

        private void Special()
        {
            using (myConnection = new OleDbConnection(myConnectionString))
            {
                myConnection.Open();

                //*** 4. Master-child relation using BindingSource  ***
                using (myOledbDataAdapter = new OleDbDataAdapter())
                {
                    DataSet myDataSet2 = new DataSet();
                    DataSet myDataSet3 = new DataSet();
                    DataSet myDataSet4 = new DataSet();
                    DataSet myDataSet5 = new DataSet();
                    DataSet myDataSetE = new DataSet();
                    DataSet myDataSetS = new DataSet();
                    DataSet myDataSetC = new DataSet();

                myOledbDataAdapter.SelectCommand = new OleDbCommand("SELECT *FROM Orders WHERE CustomerID LIKE'" + CustomerValue + "' AND EmployeeID LIKE'" + EmployeeValue + "' AND ShipVia LIKE'" + ShipperValue + "'", myConnection);
                myOledbDataAdapter.Fill(myDataSet2, "Orders");
                    
                myOledbDataAdapter.SelectCommand = new OleDbCommand("SELECT *FROM Orders WHERE CustomerID LIKE'" + CustomerValue + "' AND EmployeeID LIKE'" + EmployeeValue + "'", myConnection);
                myOledbDataAdapter.Fill(myDataSet3, "Orders");
                   
                myOledbDataAdapter.SelectCommand = new OleDbCommand("SELECT *FROM Orders WHERE CustomerID LIKE'" + CustomerValue + "' AND ShipVia LIKE'" + ShipperValue + "'", myConnection);
                myOledbDataAdapter.Fill(myDataSet4, "Orders");
                    
                myOledbDataAdapter.SelectCommand = new OleDbCommand("SELECT *FROM Orders WHERE ShipVia LIKE'" + ShipperValue + "' AND EmployeeID LIKE'" + EmployeeValue + "'", myConnection);
                myOledbDataAdapter.Fill(myDataSet5, "Orders");

                myOledbDataAdapter.SelectCommand = new OleDbCommand("SELECT *FROM Orders WHERE ShipVia LIKE'" + ShipperValue + "'", myConnection);
                myOledbDataAdapter.Fill(myDataSetS, "Orders");

                myOledbDataAdapter.SelectCommand = new OleDbCommand("SELECT *FROM Orders WHERE EmployeeID LIKE'" + EmployeeValue + "'", myConnection);
                myOledbDataAdapter.Fill(myDataSetE, "Orders");

                myOledbDataAdapter.SelectCommand = new OleDbCommand("SELECT *FROM Orders WHERE CustomerID LIKE'" + CustomerValue + "'", myConnection);
                myOledbDataAdapter.Fill(myDataSetC, "Orders");

                    bsSh.DataSource = myDataSetS;
                    bsSh.DataMember = "Orders";

                    bsCust.DataSource = myDataSetC;
                    bsCust.DataMember = "Orders";

                    bsEmp.DataSource = myDataSetE;
                    bsEmp.DataMember = "Orders";

                    bsSh.DataSource = myDataSetS;
                    bsSh.DataMember = "Orders";

                    bsOrdCustEmpShip.DataSource = myDataSet2;
                    bsOrdCustEmpShip.DataMember = "Orders";

                    bsOrdCustEmp.DataSource = myDataSet3;
                    bsOrdCustEmp.DataMember = "Orders";

                    bsOrdCustShip.DataSource = myDataSet4;
                    bsOrdCustShip.DataMember = "Orders";

                    bsOrdEmpShip.DataSource = myDataSet5;
                    bsOrdEmpShip.DataMember = "Orders";
                }
            }
            myConnection.Close(); //moramo zatvoriti konekciju
        }
        private void BindData()
        {
            using (myConnection = new OleDbConnection(myConnectionString))
            {
                myConnection.Open();

                //*** 4. Master-child relation using BindingSource  ***
                using (myOledbDataAdapter = new OleDbDataAdapter())
                {

                    DataSet myDataSet = new DataSet();
                    

                    myOledbDataAdapter.SelectCommand = new OleDbCommand("SELECT * FROM Shippers ", myConnection);
                    myOledbDataAdapter.Fill(myDataSet, "Shippers");

                    myOledbDataAdapter.SelectCommand = new OleDbCommand("SELECT * FROM Customers ", myConnection);
                    myOledbDataAdapter.Fill(myDataSet, "Customers");

                    myOledbDataAdapter.SelectCommand = new OleDbCommand("SELECT * FROM Employees ", myConnection);
                    myOledbDataAdapter.Fill(myDataSet, "Employees");

                    myOledbDataAdapter.SelectCommand = new OleDbCommand("SELECT * FROM Orders", myConnection);
                    myOledbDataAdapter.Fill(myDataSet, "Orders");

                   
                    // Establish a relationship between the two tables.
                   
                    bsEmployee.DataSource = myDataSet;
                    bsEmployee.DataMember = "Employees";

                    bsShipper.DataSource = myDataSet;
                    bsShipper.DataMember = "Shippers";

                    bsCustomer.DataSource = myDataSet;
                    bsCustomer.DataMember = "Customers";
                    
                   
                   
                    //combobox preko kategorije i definicija imena i koja vrijednost se prosljeđuje prilikom odabira(categoryID)

                    cBoCustomer.DataSource = bsCustomer;
                    cBoCustomer.DisplayMember = "CompanyName";
                    cBoCustomer.ValueMember = "CustomerID";
                  
                    cBoEmpyee.DataSource = bsEmployee;
                    cBoEmpyee.DisplayMember = "LastName";
                    cBoEmpyee.ValueMember = "EmployeeID";
                
                    cBoShipper.DataSource = bsShipper;
                    cBoShipper.DisplayMember = "CompanyName";
                    cBoShipper.ValueMember = "ShipperID";

                    //postavljanje početnog teksta comboboxova na -1, čime se postiže da nema prikaza prvih članova u listi u comboboxu kao predefinirano odabranih vrijednosti sortiranja prilikom pokretanja programa
                    cBoCustomer.SelectedIndex = -1;
                    cBoEmpyee.SelectedIndex = -1;
                    cBoShipper.SelectedIndex = -1;

                    flagCustomer = false;
                    flagEmployee = false;
                    flagShipper=false;

                    bsOrders.DataSource = myDataSet;
                    bsOrders.DataMember = "Orders";
                    dataGridView1.DataSource = bsOrders;
                    
                }
                myConnection.Close(); //moramo zatvoriti konekciju
            }
        }

    }
}
