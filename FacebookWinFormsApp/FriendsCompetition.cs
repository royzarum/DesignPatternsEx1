using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class FriendsCompetition
    {
        public bool isCompeteByLikedPages { get; private set; }
        public bool isCompeteByGroups { get; private set; }
        public bool isCompeteByMutualFriends { get; private set; }
        public User LoggedInUser { get; private set; }
        public User FriendA { get; private set; }
        public User FriendB { get; private set; }
        public FriendsClosenessResult ClosenessOfUserAndA { get; set; }
        public FriendsClosenessResult ClosenessOfUserAndB { get; set; }
        private int m_FriendAScore = 0;
        private int m_FriendBScore = 0;


        public FriendsCompetition(
            User i_LoggedInUser,
            User i_FriendA,
            User i_FriendB,
            bool i_isCompeteByLikedPages,
            bool i_isCompeteByGroups,
            bool i_isCompeteByMutualFriends
            )
        {
            LoggedInUser = i_LoggedInUser;
            FriendA = i_FriendA;
            FriendB = i_FriendB;
            isCompeteByLikedPages = i_isCompeteByLikedPages;
            isCompeteByGroups = i_isCompeteByGroups;
            isCompeteByMutualFriends = i_isCompeteByMutualFriends;
            ClosenessOfUserAndA = new FriendsClosenessResult(LoggedInUser, FriendA);
            ClosenessOfUserAndB = new FriendsClosenessResult(LoggedInUser, FriendB);
        }

        public User Compete()
        {
            User winner;

            ClosenessOfUserAndA.Run();
            ClosenessOfUserAndB.Run();

            if (isCompeteByLikedPages)
            {
                competeMutualLikedPages();
            }

            if (isCompeteByGroups)
            {
                competeMutualGroups();
            }

            if (isCompeteByMutualFriends)
            {
                competeMutualFriends();
            }

            if (m_FriendAScore > m_FriendBScore)
            {
                winner = FriendA;
            }
            else
            {
                winner = FriendB;
            }

            return winner;
        }

        private void competeMutualFriends()
        {
            if (ClosenessOfUserAndA.MutualFriends > ClosenessOfUserAndB.MutualFriends)
            {
                ++m_FriendAScore;
            }
            else if (ClosenessOfUserAndA.MutualFriends < ClosenessOfUserAndB.MutualFriends)
            {
                ++m_FriendBScore;
            }
        }

        private void competeMutualLikedPages()
        {
            if (ClosenessOfUserAndA.MutualLikedPages > ClosenessOfUserAndB.MutualLikedPages)
            {
                ++m_FriendAScore;
            }
            else if (ClosenessOfUserAndA.MutualLikedPages < ClosenessOfUserAndB.MutualLikedPages)
            {
                ++m_FriendBScore;
            }
        }

        private void competeMutualGroups()
        {
            if (ClosenessOfUserAndA.MutualGroups > ClosenessOfUserAndB.MutualGroups)
            {
                ++m_FriendAScore;
            }
            else if (ClosenessOfUserAndA.MutualGroups < ClosenessOfUserAndB.MutualGroups)
            {
                ++m_FriendBScore;
            }
        }
    }
}
