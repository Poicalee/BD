using BD1.Models;
using form111;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BD1
{
    public partial class Form10 : Form
    {
        private readonly PostgresContext context;
        private string connectionString = "Host=localhost;Username=postgres;Password=Kubek234;Database=postgres";

        public Form10()
        {
            InitializeComponent();
            context = new PostgresContext();
            wypozyczenieDatePicker.Format = DateTimePickerFormat.Custom;
            wypozyczenieDatePicker.CustomFormat = "yyyy-MM-dd";
            zwrotDatePicker.Format = DateTimePickerFormat.Custom;
            zwrotDatePicker.CustomFormat = "yyyy-MM-dd";
            get_books();
            get_employee();
            get_readers();
            RefreshListBoxWypozyczenie();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form = new Form6();
            form.ShowDialog();
            this.Close();
        }

        private void listBoxWypozyczenie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefreshListBoxWypozyczenie()
        {
            try
            {
                listBoxWypozyczenie.Items.Clear(); // Clear existing items in ListBox


                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM vw_wypozyczenie", connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string loanDate = reader.IsDBNull(0) ? "Unknown" : reader.GetDateTime(0).ToString("yyyy-MM-dd");
                                string returnDate = reader.IsDBNull(1) ? "Unknown" : reader.GetDateTime(1).ToString("yyyy-MM-dd");
                                string returned = reader.IsDBNull(2) ? "Unknown" : reader.GetBoolean(2).ToString();
                                string readerName = reader.IsDBNull(3) ? "Unknown" : reader.GetString(3);
                                string bookTitle = reader.IsDBNull(4) ? "Unknown" : reader.GetString(4);
                                string authorName = reader.IsDBNull(5) ? "Unknown" : reader.GetString(5);

                                listBoxWypozyczenie.Items.Add($"{loanDate} - {returnDate} - {returned} - {readerName} - {bookTitle} - {authorName}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching loans: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void edytujWypozyczenie_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Sprawdź, czy jakiś element jest zaznaczony w listBoxWypozyczenie
                if (listBoxWypozyczenie.SelectedItem == null)
                {
                    MessageBox.Show("Proszę zaznaczyć wypożyczenie do edycji.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Pobierz zaznaczony element z listBoxWypozyczenie
                string selectedItem = listBoxWypozyczenie.SelectedItem.ToString();

                // Pobierz loanId z zaznaczonego elementu
                int loanId = int.Parse(selectedItem.Split('-')[0].Trim());

                // Ustal wartość parametru "returned" na podstawie zaznaczonego radioButton
                bool returned = radioButton1.Checked; // Załóżmy, że radioButton1 oznacza "Nie"
                if (radioButton2.Checked)
                    returned = true; // radioButton2 oznacza "Tak"

                // Otwórz połączenie z bazą danych
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Utwórz nową komendę, wywołując procedurę EdytujWypozyczenie
                    using (NpgsqlCommand command = new NpgsqlCommand("EdytujWypozyczenie", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Dodaj parametry do komendy
                        command.Parameters.AddWithValue("@p_loan_id", loanId);
                        command.Parameters.AddWithValue("@p_returned", returned);

                        // Wykonaj komendę
                        command.ExecuteNonQuery();
                    }
                }

                // Odśwież listę wypożyczeń po edycji
                RefreshListBoxWypozyczenie();

                // Wyświetl komunikat o sukcesie
                MessageBox.Show("Wypożyczenie zostało zaktualizowane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Wyświetl komunikat o błędzie
                MessageBox.Show("Wystąpił błąd podczas edycji wypożyczenia: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void get_books()
        {
            try
            {
                // Wyczyszczenie zawartości comboBox
                Ksiazkabox.Items.Clear();

                // Połączenie z bazą danych i wykonanie zapytania SQL, które uruchamia funkcję get_books
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM book_names_view;", connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Dodanie nazwy książki do comboBox
                                string bookName = reader.GetString(0); // Załóżmy, że funkcja get_books zwraca nazwy książek w pierwszej kolumnie
                                Ksiazkabox.Items.Add(bookName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas pobierania danych o książkach: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void get_readers()
        {
            try
            {
                // Wyczyszczenie zawartości comboBox
                czytelnikbox.Items.Clear();

                // Połączenie z bazą danych i wykonanie zapytania SQL, które uruchamia funkcję get_books
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT reader_name from czytelnicy_view;", connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Dodanie nazwy książki do comboBox
                                string bookName = reader.GetString(0); // Załóżmy, że funkcja get_books zwraca nazwy książek w pierwszej kolumnie
                                czytelnikbox.Items.Add(bookName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas pobierania danych o książkach: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void get_employee()
        {
            try
            {
                // Wyczyszczenie zawartości comboBox
                pracownikbox.Items.Clear();

                // Połączenie z bazą danych i wykonanie zapytania SQL, które uruchamia funkcję get_books
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT employee_name from pracownicy_view", connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Dodanie nazwy książki do comboBox
                                string bookName = reader.GetString(0); // Załóżmy, że funkcja get_books zwraca nazwy książek w pierwszej kolumnie
                                pracownikbox.Items.Add(bookName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas pobierania danych o książkach: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DodajWypozyczenie(int readerId, int bookId, int employeeId, DateTime loanDate, DateTime returnDate, bool returned)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("dodaj_wypozyczenie", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Dodanie parametrów
                        command.Parameters.Add("p_reader_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = readerId;
                        command.Parameters.Add("p_book_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = bookId;
                        command.Parameters.Add("p_employee_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = employeeId;
                        command.Parameters.AddWithValue("p_loan_date", NpgsqlTypes.NpgsqlDbType.Date, loanDate);
                        command.Parameters.AddWithValue("p_return_date", NpgsqlTypes.NpgsqlDbType.Date, returnDate);
                        command.Parameters.AddWithValue("p_returned", NpgsqlTypes.NpgsqlDbType.Boolean).Value = returned;

                        // Wywołanie procedury
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Wypożyczenie zostało dodane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania wypożyczenia: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int PobierzIdCzytelnikaZComboBox()
        {
            // Załóżmy, że ComboBox z czytelnikami ma nazwę czytelnikComboBox
            // Zakładamy, że w ComboBox zapisane są identyfikatory czytelników jako wartości tekstowe
            // Możesz zmodyfikować nazwy ComboBox'ów, jeśli są różne
            string selectedReaderName = czytelnikbox.SelectedItem.ToString();

            // Tu wykonaj zapytanie do bazy danych, aby pobrać identyfikator czytelnika na podstawie jego nazwy
            // Przykładowe zapytanie:
            // SELECT reader_id FROM czytelnik WHERE reader_name = 'selectedReaderName';
            // Poniżej przykładowe pobranie identyfikatora z bazy danych
            int readerId = 0; // Domyślnie ustawiamy na 0, możesz też ustawić na -1 lub inny wartość oznaczającą brak wybranego czytelnika

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT reader_id FROM czytelnik WHERE reader_name = @readerName", connection))
                {
                    command.Parameters.AddWithValue("@readerName", selectedReaderName);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        readerId = Convert.ToInt32(result);
                    }
                }
            }

            return readerId;
        }

        private int PobierzIdKsiazkiZComboBox()
        {
            // Załóżmy, że ComboBox z książkami ma nazwę ksiazkaComboBox
            // Zakładamy, że w ComboBox zapisane są identyfikatory książek jako wartości tekstowe
            // Możesz zmodyfikować nazwy ComboBox'ów, jeśli są różne
            string selectedBookTitle = Ksiazkabox.SelectedItem.ToString();

            // Tu wykonaj zapytanie do bazy danych, aby pobrać identyfikator książki na podstawie jej tytułu
            // Przykładowe zapytanie:
            // SELECT book_id FROM ksiazka WHERE title = 'selectedBookTitle';
            // Poniżej przykładowe pobranie identyfikatora z bazy danych
            int bookId = 0; // Domyślnie ustawiamy na 0, możesz też ustawić na -1 lub inny wartość oznaczającą brak wybranej książki

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT book_id FROM ksiązki WHERE title = @bookTitle", connection))
                {
                    command.Parameters.AddWithValue("@bookTitle", selectedBookTitle);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        bookId = Convert.ToInt32(result);
                    }
                }
            }

            return bookId;
        }

        private int PobierzIdPracownikaZComboBox()
        {
            // Załóżmy, że ComboBox z pracownikami ma nazwę pracownikComboBox
            // Zakładamy, że w ComboBox zapisane są identyfikatory pracowników jako wartości tekstowe
            // Możesz zmodyfikować nazwy ComboBox'ów, jeśli są różne
            string selectedEmployeeName = pracownikbox.SelectedItem.ToString();

            // Tu wykonaj zapytanie do bazy danych, aby pobrać identyfikator pracownika na podstawie jego nazwy
            // Przykładowe zapytanie:
            // SELECT employee_id FROM pracownik WHERE employee_name = 'selectedEmployeeName';
            // Poniżej przykładowe pobranie identyfikatora z bazy danych
            int employeeId = 0; // Domyślnie ustawiamy na 0, możesz też ustawić na -1 lub inny wartość oznaczającą brak wybranego pracownika

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT employee_id FROM pracownik WHERE employee_name = @employeeName", connection))
                {
                    command.Parameters.AddWithValue("@employeeName", selectedEmployeeName);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        employeeId = Convert.ToInt32(result);
                    }
                }
            }

            return employeeId;
        }

        private void dodajWypozyczenie_Click(object sender, EventArgs e)
        {
            try
            {
                // Pobierz identyfikatory czytelnika, książki i pracownika z ComboBox'ów
                int readerId = PobierzIdCzytelnikaZComboBox();
                int bookId = PobierzIdKsiazkiZComboBox();
                int employeeId = PobierzIdPracownikaZComboBox();
                DateTime loanDate = wypozyczenieDatePicker.Value;
                DateTime returnDate = zwrotDatePicker.Value;

                // Sprawdź, który radioButton został zaznaczony, aby określić wartość parametru "returned"
                bool returned = radioButton1.Checked; // Załóżmy, że radioButton1 oznacza "Nie"
                if (radioButton2.Checked)
                    returned = false; // radioButton2 oznacza "Tak"

                // Wywołaj metodę DodajWypozyczenie z przekazanymi danymi, w tym parametrem "returned"
                DodajWypozyczenie(readerId, bookId, employeeId, loanDate, returnDate, returned);

                // Odśwież listę wypożyczeń po dodaniu nowego wypożyczenia
                RefreshListBoxWypozyczenie();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania wypożyczenia: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UsunWypozyczenie(int loanId)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("usun_wypozyczenie", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Dodanie parametru
                        command.Parameters.AddWithValue("p_loan_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = loanId;

                        // Wywołanie procedury
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Wypożyczenie zostało usunięte.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas usuwania wypożyczenia: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usunWypozyczenie_Click(object sender, EventArgs e)
        {
            try
            {
                // Pobierz zaznaczony element z listBoxWypozyczenie
                string selectedItem = listBoxWypozyczenie.SelectedItem.ToString();

                // Sprawdź czy coś jest zaznaczone
                if (selectedItem == null)
                {
                    MessageBox.Show("Proszę zaznaczyć wypożyczenie do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Pobierz loanId z zaznaczonego elementu
                int loanId = int.Parse(selectedItem.Split('-')[0].Trim());

                // Wywołaj metodę UsunWypozyczenie z przekazanym loanId
                UsunWypozyczenie(loanId);

                // Odśwież listę wypożyczeń po usunięciu
                RefreshListBoxWypozyczenie();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas usuwania wypożyczenia: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wylogujBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }
    }
}
