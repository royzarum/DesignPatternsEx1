using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class FriendsClosenessResult
    {
        public User FriendA { get; set; }
        public User FriendB { get; set; }
        public int MutualLikedPages { get; private set; }
        public int MutualGroups { get; private set; }
        public int MutualFriends { get; private set; }

        public FriendsClosenessResult(User i_FriendA, User i_FriendB)
        {
            if (i_FriendA == null || i_FriendB == null)
            {
                throw new ArgumentNullException("Cannot create with null partisipants");
            }

            FriendA = i_FriendA;
            FriendB = i_FriendB;
        }

        public void Run()
        {
            MutualLikedPages = countMutualLikedPages();
            MutualGroups = countMutualGroups();
            MutualFriends = countMutualFriends();
        }

        private int countMutualFriends()
        {
            int counter = 0;

            foreach (User friendOfA in FriendA.Friends)
            {
                if (FriendB.Friends.Contains(friendOfA))
                {
                    ++counter;
                }
            }

            return counter;
        }

        private int countMutualGroups()
        {
            int counter = 0;

            foreach (Group groupOfA in FriendA.Groups)
            {
                if (FriendB.Groups.Contains(groupOfA))
                {
                    ++counter;
                }
            }

            return counter;
        }

        private int countMutualLikedPages()
        {
            int counter = 0;

            foreach (Page likedPageOfA in FriendA.LikedPages)
            {
                if (FriendB.LikedPages.Contains(likedPageOfA))
                {
                    ++counter;
                }
            }

            return counter;
        }
    }
}
