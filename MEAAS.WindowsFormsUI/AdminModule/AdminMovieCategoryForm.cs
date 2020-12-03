using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEAAS.Business.Abstract;
using MEAAS.Business.DependencyResolvers.Ninject;
using MEAAS.Entities.Concrete;

namespace MEAAS.WindowsFormsUI.AdminModule
{
    public partial class AdminMovieCategoryForm : Form
    {
        public AdminMovieCategoryForm()
        {
            InitializeComponent();
        }
        private readonly IMovieCategoryService _movieCategoryService = InstanceFactory.GetInstance<IMovieCategoryService>();

        private void AdminMovieCategoryForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRemoveMovie_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateMovieCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveMovieCategory_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            AdminHomeMenuForm adminHomeMenuForm = new AdminHomeMenuForm();
            adminHomeMenuForm.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void BtnAddMovieCategory_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var name = tbxMovieCategoryName.Text;

        //        if (name == string.Empty)
        //        {
        //            MessageBox.Show(@"can't be blank");
        //        }
        //        else
        //        {
        //            var movieCategory = _movieCategoryService.GetMovieCategoryByMovieCategoryName(name);
        //            if (movieCategory == null)
        //            {
        //                var savedMovieCategory = _movieCategoryService.AddMovieCategory(new MovieCategory
        //                {
        //                    MovieCategoryName = name
        //                });
        //                if (savedMovieCategory != null)
        //                {
        //                    LoadMovieCategories();
        //                    tbxMovieCategoryName.Text = "";

        //                    MessageBox.Show(@"new movie category added.");
        //                }
        //                else
        //                {
        //                    MessageBox.Show(@"Couldn't add new movie category!!");
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show(@"this movie category has already been added");
        //            }
        //        }

        //    }
        //    catch (Exception exception)
        //    {
        //        MessageBox.Show(exception.Message);
        //    }
        //}
        //private void LoadMovieCategories()
        //{

        //    var movieCategories = _movieCategoryService.GetAllMovieCategories();
        //    dgwMovieCategory.DataSource = movieCategories;

        //    cbxMovieCategory.DataSource = movieCategories;
        //    cbxMovieCategory.DisplayMember = "MovieCategoryName";
        //    cbxMovieCategory.ValueMember = "MovieCategoryId";

        //    cbxUpdateMovieCategory.DataSource = movieCategories;
        //    cbxUpdateMovieCategory.DisplayMember = "MovieCategoryName";
        //    cbxUpdateMovieCategory.ValueMember = "MovieCategoryId";

        //}
        //private void BtnUpdateMovieCategory_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var name = tbxUpdateMovieCategoryName.Text;

        //        if (name == string.Empty)
        //        {
        //            MessageBox.Show(@"can't be blank");
        //        }
        //        else
        //        {
        //            var movieCategory = _movieCategoryService.GetMovieCategoryByMovieCategoryName(name);
        //            if (dgwMovies.CurrentRow != null)
        //            {
        //                var updatedMovieCategory = _movieCategoryService.UpdateMovieCategory(new MovieCategory
        //                {
        //                    MovieCategoryId = Convert.ToInt32(dgwMovies.CurrentRow.Cells[0].Value),
        //                    MovieCategoryName = name
        //                });
        //                if (updatedMovieCategory != null)
        //                {
        //                    LoadMovieCategories();
        //                    MessageBox.Show(@"movie category updated.");
        //                }
        //                else
        //                {
        //                    MessageBox.Show(@"Couldn't update movie category!!");
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show(@"There is no such movie category");
        //            }
        //        }
        //    }
        //    catch (Exception exception)
        //    {
        //        MessageBox.Show(exception.Message);
        //    }
        //}
        //private void BtnRemoveMovieCategory_Click(object sender, EventArgs e)
        //{
        //    if (dgwMovieCategory.CurrentRow != null)
        //    {
        //        _movieCategoryService.DeleteMovieCategory(new MovieCategory
        //        {
        //            MovieCategoryId = Convert.ToInt32(dgwMovieCategory.CurrentRow.Cells[0].Value)
        //        });
        //        LoadMovieCategories();
        //        MessageBox.Show(@"Movie category Deleted!");
        //    }
        //    else
        //    {
        //        MessageBox.Show(@"Please Select Movie category!");
        //    }
        //}
        //private void DgwMovieCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dgwMovieCategory.CurrentRow != null)
        //    {
        //        tbxUpdateMovieCategoryName.Text = dgwMovieCategory.CurrentRow.Cells[1].Value.ToString();
        //    }
        //}
        //private void TbxSearchMovieCategory_TextChanged(object sender, EventArgs e)
        //{
        //    if (!String.IsNullOrEmpty(tbxSearchMovieCategory.Text))
        //    {
        //        dgwMovieCategory.DataSource = _movieCategoryService.GetMovieCategoriesByCategoryName(tbxSearchMovieCategory.Text);
        //    }
        //    else
        //    {
        //        LoadMovieCategories();
        //    }
        //}
    }
}
