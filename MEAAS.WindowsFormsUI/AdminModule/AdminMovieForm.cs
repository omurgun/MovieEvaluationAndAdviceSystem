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
    public partial class AdminMovieForm : Form
    {
        public AdminMovieForm()
        {
            InitializeComponent();
        }

        private readonly IMovieService _movieService = InstanceFactory.GetInstance<IMovieService>();
        private readonly IMovieCategoryService _movieCategoryService = InstanceFactory.GetInstance<IMovieCategoryService>();
       
        private void AdminMovieForm_Load(object sender, EventArgs e)
        {
            LoadMovieCategories();
            LoadMovies();
        }

        private void LoadMovieCategories()
        {

            var movieCategories =_movieCategoryService.GetAllMovieCategories();
            dgwMovieCategory.DataSource = movieCategories;

            cbxMovieCategory.DataSource = movieCategories;
            cbxMovieCategory.DisplayMember = "MovieCategoryName";
            cbxMovieCategory.ValueMember = "MovieCategoryId";

            cbxUpdateMovieCategory.DataSource = movieCategories;
            cbxUpdateMovieCategory.DisplayMember = "MovieCategoryName";
            cbxUpdateMovieCategory.ValueMember = "MovieCategoryId";
            
        }
        private void LoadMovies()
        {
            dgwMovies.DataSource = _movieService.GetAllMovies();
        }

        private void BtnAddMovie_Click(object sender, EventArgs e)
        {
            try
            {
                var title = tbxTitle.Text;
                var category = cbxMovieCategory.SelectedValue.ToString();
                var thumbnailUrl = tbxThumbnailUrl.Text;
                

                if (title == string.Empty || category == string.Empty || thumbnailUrl == string.Empty )
                {
                    MessageBox.Show(@"can't be blank");
                }
                else
                {
                    var movie = _movieService.GetMovieByTitle(title);
                    if (movie == null)
                    {
                        var savedMovie = _movieService.AddMovie(new Movie
                        {
                            MovieTitle = title,
                            MovieThumbnail = thumbnailUrl,
                            MovieCategoryId = Convert.ToInt32(category)
                        });
                        if (savedMovie != null)
                        {
                            LoadMovies();
                            tbxTitle.Text = "";
                            tbxThumbnailUrl.Text = "";

                            MessageBox.Show(@"new movie added.");
                        }
                        else
                        {
                            MessageBox.Show(@"Couldn't add new movie!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"this movie has already been added");
                    }
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void BtnUpdateMovie_Click(object sender, EventArgs e)
        {
            try
            {
                var updateTitle = tbxUpdateTitle.Text;
                var updateCategory = cbxUpdateMovieCategory.SelectedValue.ToString();
                var updateThumbnailUrl = tbxUpdateThumbnailUrl.Text;


                if (updateTitle == string.Empty || updateCategory == string.Empty || updateThumbnailUrl == string.Empty)
                {
                    MessageBox.Show(@"can't be blank");
                }
                else
                {
                    var movie = _movieService.GetMovieByTitle(updateTitle);
                    if (movie != null)
                    {
                        if (dgwMovies.CurrentRow != null)
                        {
                            var updatedMovie = _movieService.UpdateMovie(new Movie
                            {
                                Id = Convert.ToInt32(dgwMovies.CurrentRow.Cells[0].Value),
                                MovieTitle = updateTitle,
                                MovieThumbnail = updateThumbnailUrl,
                                MovieCategoryId = Convert.ToInt32(updateCategory)
                            });
                            if (updatedMovie != null)
                            {
                                LoadMovies();
                                MessageBox.Show(@"movie updated.");
                            }
                            else
                            {
                                MessageBox.Show(@"Couldn't update movie!!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"There is no such movie");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void TbxRemoveMovie_Click(object sender, EventArgs e)
        {
            if (dgwMovies.CurrentRow != null)
            {
                _movieService.DeleteMovie(new Movie
                {
                    Id = Convert.ToInt32(dgwMovies.CurrentRow.Cells[0].Value)
                });
                LoadMovies();
                MessageBox.Show(@"Movie Deleted!");
            }
            else
            {
                MessageBox.Show(@"Please Select Movie!");
            }
        }


        private void BtnAddMovieCategory_Click(object sender, EventArgs e)
        {
            try
            {
                var name = tbxMovieCategoryName.Text;
                
                if (name == string.Empty)
                {
                    MessageBox.Show(@"can't be blank");
                }
                else
                {
                    var movieCategory = _movieCategoryService.GetMovieCategoryByMovieCategoryName(name);
                    if (movieCategory == null)
                    {
                        var savedMovieCategory = _movieCategoryService.AddMovieCategory(new MovieCategory
                        {
                           MovieCategoryName = name
                        });
                        if (savedMovieCategory != null)
                        {
                            LoadMovieCategories();
                            tbxMovieCategoryName.Text = "";

                            MessageBox.Show(@"new movie category added.");
                        }
                        else
                        {
                            MessageBox.Show(@"Couldn't add new movie category!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"this movie category has already been added");
                    }
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void BtnUpdateMovieCategory_Click(object sender, EventArgs e)
        {
            try
            {
                var name = tbxUpdateMovieCategoryName.Text;

                if (name == string.Empty)
                {
                    MessageBox.Show(@"can't be blank");
                }
                else
                {
                    var movieCategory = _movieCategoryService.GetMovieCategoryByMovieCategoryName(name);
                    if (dgwMovies.CurrentRow != null)
                    {
                        var updatedMovieCategory = _movieCategoryService.UpdateMovieCategory(new MovieCategory
                        {
                            MovieCategoryId = Convert.ToInt32(dgwMovies.CurrentRow.Cells[0].Value),
                            MovieCategoryName = name
                        });
                        if (updatedMovieCategory != null)
                        {
                            LoadMovieCategories();
                            MessageBox.Show(@"movie category updated.");
                        }
                        else
                        {
                            MessageBox.Show(@"Couldn't update movie category!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"There is no such movie category");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void BtnRemoveMovieCategory_Click(object sender, EventArgs e)
        {
            if (dgwMovieCategory.CurrentRow != null)
            {
                _movieCategoryService.DeleteMovieCategory(new MovieCategory
                {
                    MovieCategoryId = Convert.ToInt32(dgwMovieCategory.CurrentRow.Cells[0].Value)
                });
                LoadMovieCategories();
                MessageBox.Show(@"Movie category Deleted!");
            }
            else
            {
                MessageBox.Show(@"Please Select Movie category!");
            }
        }

        private void DgwMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwMovies.CurrentRow != null)
            {
                tbxUpdateTitle.Text = dgwMovies.CurrentRow.Cells[2].Value.ToString();
                cbxUpdateMovieCategory.SelectedValue = dgwMovies.CurrentRow.Cells[1].Value;
                tbxUpdateThumbnailUrl.Text = dgwMovies.CurrentRow.Cells[3].Value.ToString();
                
            }
        }
        private void DgwMovieCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwMovieCategory.CurrentRow != null)
            {
                tbxUpdateMovieCategoryName.Text = dgwMovieCategory.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void TbxMovieSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxMovieSearch.Text))
            {
                dgwMovies.DataSource = _movieService.GetMoviesByTitle(tbxMovieSearch.Text);
            }
            else
            {
                LoadMovies();
            }
        }

        private void TbxSearchMovieCategory_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxSearchMovieCategory.Text))
            {
                dgwMovieCategory.DataSource = _movieCategoryService.GetMovieCategoriesByCategoryName(tbxSearchMovieCategory.Text);
            }
            else
            {
                LoadMovieCategories();
            }
        }
    }
}
