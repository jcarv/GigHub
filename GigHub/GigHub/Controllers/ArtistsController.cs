using GigHub.Models;
using GigHub.ViewModels;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace GigHub.Controllers
{
    public class ArtistsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArtistsController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Following()
        {
            var userId = User.Identity.GetUserId();

            var followees = _context.Followings
                .Where(a => a.FollowerId == userId)
                .Select(a => a.Followee)
                .ToList();

            var viewModel = new FollowingViewModel()
            {
                Followees = followees,
                ShowActions = User.Identity.IsAuthenticated,
                Heading = "Artists I'm Following"
            };

            return View("Followings", viewModel);
        }
    }
}