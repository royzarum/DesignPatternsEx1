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
                competeCategory(ClosenessOfUserAndA.MutualLikedPages, ClosenessOfUserAndB.MutualLikedPages);
            }

            if (isCompeteByGroups)
            {
                competeCategory(ClosenessOfUserAndA.MutualGroups, ClosenessOfUserAndB.MutualGroups);
            }

            if (isCompeteByMutualFriends)
            {
                competeCategory(ClosenessOfUserAndA.MutualFriends, ClosenessOfUserAndB.MutualFriends);
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

        private void competeCategory(int i_resultA, int i_resultB)
        {
            if (i_resultA > i_resultB)
            {
                ++m_FriendAScore;
            }
            else if (i_resultA < i_resultB)
            {
                ++m_FriendBScore;
            }
        }
    }
}
