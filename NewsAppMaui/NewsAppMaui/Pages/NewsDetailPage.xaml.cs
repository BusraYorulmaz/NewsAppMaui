using NewsAppMaui.Models;

namespace NewsAppMaui.Pages;

public partial class NewsDetailPage : ContentPage
{
	public NewsDetailPage(Article article)
	{
		InitializeComponent();
		ImgNews.Source= article.Image;
		LbTitle.Text= article.Title;
		LbContent.Text=	article.Content;

	}
}