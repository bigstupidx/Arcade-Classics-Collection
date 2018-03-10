using UnityEngine;
using System.Collections;
using UnityEngine.SocialPlatforms;

public class GooglePlayServices : MonoBehaviour
{



	void Start()
	{




	}

	public void OnShowLeaderBoardSnake()
	{
		//Social.ShowLeaderboardUI (); // Show all leaderboard
//		PlayGamesPlatform.Instance.ShowLeaderboardUI (GPGSIds.leaderboard_snake); // Show current (Active) leaderboard
	}

	public void OnShowLeaderBoardArkanoid()
	{
		//Social.ShowLeaderboardUI (); // Show all leaderboard
//		PlayGamesPlatform.Instance.ShowLeaderboardUI (GPGSIds.leaderboard_arkanoid); // Show current (Active) leaderboard
	}

	public void OnShowLeaderBoardPacman()
	{
		//Social.ShowLeaderboardUI (); // Show all leaderboard
//		PlayGamesPlatform.Instance.ShowLeaderboardUI (GPGSIds.leaderboard_pacman); // Show current (Active) leaderboard
	}

	public void OnAddScoreToLeaderBoard()
	{
//		if (Social.localUser.authenticated) {
//
//
//			Social.ReportScore(PlayerPrefs.GetInt("puntosSnake"), GPGSIds.leaderboard_snake, (bool success) => {
//				if (success) {
//					Debug.Log("Update Score Success");
//				} else {
//					Debug.Log("Update Score Fail");
//				}
//			});
//			Social.ReportScore(PlayerPrefs.GetInt("puntosArkanoid"), GPGSIds.leaderboard_arkanoid, (bool success) => {
//				if (success) {
//					Debug.Log("Update Score Success");
//				} else {
//					Debug.Log("Update Score Fail");
//				}
//			});			
//			Social.ReportScore(PlayerPrefs.GetInt("puntosPacman"), GPGSIds.leaderboard_pacman, (bool success) => {
//				if (success) {
//					Debug.Log("Update Score Success");
//				} else {
//					Debug.Log("Update Score Fail");
//				}
//			});
//		}
	}



}


