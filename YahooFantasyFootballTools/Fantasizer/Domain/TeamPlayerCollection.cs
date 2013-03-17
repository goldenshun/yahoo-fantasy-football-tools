﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Fantasizer.Domain
{
    public class TeamPlayerCollection<TPlayerType> where TPlayerType : Player
    {
        internal TeamPlayerCollection(XElement teamElement)
        {
            this.Team = Team.CreateFromXml(teamElement);
            this.Players = new PlayerCollection<TPlayerType>(teamElement);
        }

        public Team Team { get; private set; }
        public PlayerCollection<TPlayerType> Players { get; private set; }
    }
}

/*
<fantasy_content xml:lang="en-US" yahoo:uri="http://fantasysports.yahooapis.com/fantasy/v2/team/273.l.86177.t.4/players" xmlns:yahoo="http://www.yahooapis.com/v1/base.rng" time="130.40089607239ms" copyright="Data provided by Yahoo! and STATS, LLC" refresh_rate="60" xmlns="http://fantasysports.yahooapis.com/fantasy/v2/base.rng">
  <team>
    <team_key>273.l.86177.t.4</team_key>
    <team_id>4</team_id>
    <name>Wookie of the Year</name>
    <is_owned_by_current_login>1</is_owned_by_current_login>
    <url>http://football.fantasysports.yahoo.com/archive/nfl/2012/86177/4</url>
    <team_logos>
      <team_logo>
        <size>medium</size>
        <url>http://l.yimg.com/a/i/identity2/profile_48e.png</url>
      </team_logo>
    </team_logos>
    <division_id>2</division_id>
    <waiver_priority>4</waiver_priority>
    <number_of_moves>29</number_of_moves>
    <number_of_trades>1</number_of_trades>
    <roster_adds>
      <coverage_type>week</coverage_type>
      <coverage_value>17</coverage_value>
      <value>0</value>
    </roster_adds>
    <clinched_playoffs>1</clinched_playoffs>
    <managers>
      <manager>
        <manager_id>4</manager_id>
        <nickname>Sean</nickname>
        <guid>K5FUJQOYBEFUDKCE6ABRSYEB2I</guid>
        <is_current_login>1</is_current_login>
      </manager>
    </managers>
    <players count="15">
      <player>
        <player_key>273.p.6243</player_key>
        <player_id>6243</player_id>
        <name>
          <full>Matt Bryant</full>
          <first>Matt</first>
          <last>Bryant</last>
          <ascii_first>Matt</ascii_first>
          <ascii_last>Bryant</ascii_last>
        </name>
        <editorial_player_key>nfl.p.6243</editorial_player_key>
        <editorial_team_key>nfl.t.1</editorial_team_key>
        <editorial_team_full_name>Atlanta Falcons</editorial_team_full_name>
        <editorial_team_abbr>Atl</editorial_team_abbr>
        <bye_weeks>
          <week>7</week>
        </bye_weeks>
        <uniform_number>3</uniform_number>
        <display_position>K</display_position>
        <headshot>
          <url>http://l.yimg.com/iu/api/res/1.2/9a4LtRseixjvK2la9Qe.VA--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/6243.jpg</url>
          <size>small</size>
        </headshot>
        <image_url>http://l.yimg.com/iu/api/res/1.2/9a4LtRseixjvK2la9Qe.VA--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/6243.jpg</image_url>
        <is_undroppable>0</is_undroppable>
        <position_type>K</position_type>
        <eligible_positions>
          <position>K</position>
        </eligible_positions>
      </player>
      <player>
        <player_key>273.p.6624</player_key>
        <player_id>6624</player_id>
        <name>
          <full>Tony Romo</full>
          <first>Tony</first>
          <last>Romo</last>
          <ascii_first>Tony</ascii_first>
          <ascii_last>Romo</ascii_last>
        </name>
        <editorial_player_key>nfl.p.6624</editorial_player_key>
        <editorial_team_key>nfl.t.6</editorial_team_key>
        <editorial_team_full_name>Dallas Cowboys</editorial_team_full_name>
        <editorial_team_abbr>Dal</editorial_team_abbr>
        <bye_weeks>
          <week>5</week>
        </bye_weeks>
        <uniform_number>9</uniform_number>
        <display_position>QB</display_position>
        <headshot>
          <url>http://l.yimg.com/iu/api/res/1.2/QzM9NrOZhQpO8dS63PAKug--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/6624.jpg</url>
          <size>small</size>
        </headshot>
        <image_url>http://l.yimg.com/iu/api/res/1.2/QzM9NrOZhQpO8dS63PAKug--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/6624.jpg</image_url>
        <is_undroppable>0</is_undroppable>
        <position_type>O</position_type>
        <eligible_positions>
          <position>QB</position>
        </eligible_positions>
      </player>
      <player>
        <player_key>273.p.6783</player_key>
        <player_id>6783</player_id>
        <name>
          <full>Steven Jackson</full>
          <first>Steven</first>
          <last>Jackson</last>
          <ascii_first>Steven</ascii_first>
          <ascii_last>Jackson</ascii_last>
        </name>
        <status>P</status>
        <editorial_player_key>nfl.p.6783</editorial_player_key>
        <editorial_team_key>nfl.t.14</editorial_team_key>
        <editorial_team_full_name>St. Louis Rams</editorial_team_full_name>
        <editorial_team_abbr>StL</editorial_team_abbr>
        <bye_weeks>
          <week>9</week>
        </bye_weeks>
        <uniform_number>39</uniform_number>
        <display_position>RB</display_position>
        <headshot>
          <url>http://l.yimg.com/iu/api/res/1.2/0qk0Z7y1UnhlVILVUnDwmw--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/6783.jpg</url>
          <size>small</size>
        </headshot>
        <image_url>http://l.yimg.com/iu/api/res/1.2/0qk0Z7y1UnhlVILVUnDwmw--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/6783.jpg</image_url>
        <is_undroppable>0</is_undroppable>
        <position_type>O</position_type>
        <eligible_positions>
          <position>RB</position>
          <position>W/R</position>
        </eligible_positions>
        <has_player_notes>1</has_player_notes>
      </player>
      <player>
        <player_key>273.p.7776</player_key>
        <player_id>7776</player_id>
        <name>
          <full>DeAngelo Williams</full>
          <first>DeAngelo</first>
          <last>Williams</last>
          <ascii_first>DeAngelo</ascii_first>
          <ascii_last>Williams</ascii_last>
        </name>
        <status>P</status>
        <editorial_player_key>nfl.p.7776</editorial_player_key>
        <editorial_team_key>nfl.t.29</editorial_team_key>
        <editorial_team_full_name>Carolina Panthers</editorial_team_full_name>
        <editorial_team_abbr>Car</editorial_team_abbr>
        <bye_weeks>
          <week>6</week>
        </bye_weeks>
        <uniform_number>34</uniform_number>
        <display_position>RB</display_position>
        <headshot>
          <url>http://l.yimg.com/iu/api/res/1.2/iHVO6j0a.lHC.eRpqKtltg--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/7776.jpg</url>
          <size>small</size>
        </headshot>
        <image_url>http://l.yimg.com/iu/api/res/1.2/iHVO6j0a.lHC.eRpqKtltg--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/7776.jpg</image_url>
        <is_undroppable>0</is_undroppable>
        <position_type>O</position_type>
        <eligible_positions>
          <position>RB</position>
          <position>W/R</position>
        </eligible_positions>
      </player>
      <player>
        <player_key>273.p.7847</player_key>
        <player_id>7847</player_id>
        <name>
          <full>Owen Daniels</full>
          <first>Owen</first>
          <last>Daniels</last>
          <ascii_first>Owen</ascii_first>
          <ascii_last>Daniels</ascii_last>
        </name>
        <status>P</status>
        <editorial_player_key>nfl.p.7847</editorial_player_key>
        <editorial_team_key>nfl.t.34</editorial_team_key>
        <editorial_team_full_name>Houston Texans</editorial_team_full_name>
        <editorial_team_abbr>Hou</editorial_team_abbr>
        <bye_weeks>
          <week>8</week>
        </bye_weeks>
        <uniform_number>81</uniform_number>
        <display_position>TE</display_position>
        <headshot>
          <url>http://l.yimg.com/iu/api/res/1.2/5.ft7CCrNxm5IR5B4Aq.MQ--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/7847.jpg</url>
          <size>small</size>
        </headshot>
        <image_url>http://l.yimg.com/iu/api/res/1.2/5.ft7CCrNxm5IR5B4Aq.MQ--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/7847.jpg</image_url>
        <is_undroppable>0</is_undroppable>
        <position_type>O</position_type>
        <eligible_positions>
          <position>TE</position>
        </eligible_positions>
      </player>
      <player>
        <player_key>273.p.8001</player_key>
        <player_id>8001</player_id>
        <name>
          <full>Marques Colston</full>
          <first>Marques</first>
          <last>Colston</last>
          <ascii_first>Marques</ascii_first>
          <ascii_last>Colston</ascii_last>
        </name>
        <editorial_player_key>nfl.p.8001</editorial_player_key>
        <editorial_team_key>nfl.t.18</editorial_team_key>
        <editorial_team_full_name>New Orleans Saints</editorial_team_full_name>
        <editorial_team_abbr>NO</editorial_team_abbr>
        <bye_weeks>
          <week>6</week>
        </bye_weeks>
        <uniform_number>12</uniform_number>
        <display_position>WR</display_position>
        <headshot>
          <url>http://l.yimg.com/iu/api/res/1.2/X_pYpB3OrZxwjavgtdgTUA--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/8001.jpg</url>
          <size>small</size>
        </headshot>
        <image_url>http://l.yimg.com/iu/api/res/1.2/X_pYpB3OrZxwjavgtdgTUA--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/8001.jpg</image_url>
        <is_undroppable>0</is_undroppable>
        <position_type>O</position_type>
        <eligible_positions>
          <position>WR</position>
          <position>W/R</position>
        </eligible_positions>
      </player>
      <player>
        <player_key>273.p.9158</player_key>
        <player_id>9158</player_id>
        <name>
          <full>Marcel Reece</full>
          <first>Marcel</first>
          <last>Reece</last>
          <ascii_first>Marcel</ascii_first>
          <ascii_last>Reece</ascii_last>
        </name>
        <editorial_player_key>nfl.p.9158</editorial_player_key>
        <editorial_team_key>nfl.t.13</editorial_team_key>
        <editorial_team_full_name>Oakland Raiders</editorial_team_full_name>
        <editorial_team_abbr>Oak</editorial_team_abbr>
        <bye_weeks>
          <week>5</week>
        </bye_weeks>
        <uniform_number>45</uniform_number>
        <display_position>RB</display_position>
        <headshot>
          <url>http://l.yimg.com/iu/api/res/1.2/Ty5lALvLBuC9h1pCk44zgA--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/9158.jpg</url>
          <size>small</size>
        </headshot>
        <image_url>http://l.yimg.com/iu/api/res/1.2/Ty5lALvLBuC9h1pCk44zgA--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/9158.jpg</image_url>
        <is_undroppable>0</is_undroppable>
        <position_type>O</position_type>
        <eligible_positions>
          <position>RB</position>
          <position>W/R</position>
        </eligible_positions>
      </player>
      <player>
        <player_key>273.p.9286</player_key>
        <player_id>9286</player_id>
        <name>
          <full>Percy Harvin</full>
          <first>Percy</first>
          <last>Harvin</last>
          <ascii_first>Percy</ascii_first>
          <ascii_last>Harvin</ascii_last>
        </name>
        <editorial_player_key>nfl.p.9286</editorial_player_key>
        <editorial_team_key>nfl.t.16</editorial_team_key>
        <editorial_team_full_name>Minnesota Vikings</editorial_team_full_name>
        <editorial_team_abbr>Min</editorial_team_abbr>
        <bye_weeks>
          <week>11</week>
        </bye_weeks>
        <uniform_number>12</uniform_number>
        <display_position>WR</display_position>
        <headshot>
          <url>http://l.yimg.com/iu/api/res/1.2/eYoPBUOdBDFOHkkARe6Cpg--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/9286.jpg</url>
          <size>small</size>
        </headshot>
        <image_url>http://l.yimg.com/iu/api/res/1.2/eYoPBUOdBDFOHkkARe6Cpg--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/9286.jpg</image_url>
        <is_undroppable>0</is_undroppable>
        <position_type>O</position_type>
        <eligible_positions>
          <position>WR</position>
          <position>W/R</position>
        </eligible_positions>
        <has_player_notes>1</has_player_notes>
      </player>
      <player>
        <player_key>273.p.9317</player_key>
        <player_id>9317</player_id>
        <name>
          <full>LeSean McCoy</full>
          <first>LeSean</first>
          <last>McCoy</last>
          <ascii_first>LeSean</ascii_first>
          <ascii_last>McCoy</ascii_last>
        </name>
        <editorial_player_key>nfl.p.9317</editorial_player_key>
        <editorial_team_key>nfl.t.21</editorial_team_key>
        <editorial_team_full_name>Philadelphia Eagles</editorial_team_full_name>
        <editorial_team_abbr>Phi</editorial_team_abbr>
        <bye_weeks>
          <week>7</week>
        </bye_weeks>
        <uniform_number>25</uniform_number>
        <display_position>RB</display_position>
        <headshot>
          <url>http://l.yimg.com/iu/api/res/1.2/d9irh1.HSnJUE6VpnE5wnA--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/9317.jpg</url>
          <size>small</size>
        </headshot>
        <image_url>http://l.yimg.com/iu/api/res/1.2/d9irh1.HSnJUE6VpnE5wnA--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/9317.jpg</image_url>
        <is_undroppable>0</is_undroppable>
        <position_type>O</position_type>
        <eligible_positions>
          <position>RB</position>
          <position>W/R</position>
        </eligible_positions>
      </player>
      <player>
        <player_key>273.p.23997</player_key>
        <player_id>23997</player_id>
        <name>
          <full>Demaryius Thomas</full>
          <first>Demaryius</first>
          <last>Thomas</last>
          <ascii_first>Demaryius</ascii_first>
          <ascii_last>Thomas</ascii_last>
        </name>
        <editorial_player_key>nfl.p.23997</editorial_player_key>
        <editorial_team_key>nfl.t.7</editorial_team_key>
        <editorial_team_full_name>Denver Broncos</editorial_team_full_name>
        <editorial_team_abbr>Den</editorial_team_abbr>
        <bye_weeks>
          <week>7</week>
        </bye_weeks>
        <uniform_number>88</uniform_number>
        <display_position>WR</display_position>
        <headshot>
          <url>http://l.yimg.com/iu/api/res/1.2/jYyx4DId0I4.nVfxmO49Lw--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/23997.jpg</url>
          <size>small</size>
        </headshot>
        <image_url>http://l.yimg.com/iu/api/res/1.2/jYyx4DId0I4.nVfxmO49Lw--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/23997.jpg</image_url>
        <is_undroppable>1</is_undroppable>
        <position_type>O</position_type>
        <eligible_positions>
          <position>WR</position>
          <position>W/R</position>
        </eligible_positions>
      </player>
      <player>
        <player_key>273.p.24791</player_key>
        <player_id>24791</player_id>
        <name>
          <full>A.J. Green</full>
          <first>A.J.</first>
          <last>Green</last>
          <ascii_first>A.J.</ascii_first>
          <ascii_last>Green</ascii_last>
        </name>
        <editorial_player_key>nfl.p.24791</editorial_player_key>
        <editorial_team_key>nfl.t.4</editorial_team_key>
        <editorial_team_full_name>Cincinnati Bengals</editorial_team_full_name>
        <editorial_team_abbr>Cin</editorial_team_abbr>
        <bye_weeks>
          <week>8</week>
        </bye_weeks>
        <uniform_number>18</uniform_number>
        <display_position>WR</display_position>
        <headshot>
          <url>http://l.yimg.com/iu/api/res/1.2/7vskqHTaLtfPfPT4z8viCQ--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/24791.jpg</url>
          <size>small</size>
        </headshot>
        <image_url>http://l.yimg.com/iu/api/res/1.2/7vskqHTaLtfPfPT4z8viCQ--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/24791.jpg</image_url>
        <is_undroppable>1</is_undroppable>
        <position_type>O</position_type>
        <eligible_positions>
          <position>WR</position>
          <position>W/R</position>
        </eligible_positions>
      </player>
      <player>
        <player_key>273.p.24822</player_key>
        <player_id>24822</player_id>
        <name>
          <full>Andy Dalton</full>
          <first>Andy</first>
          <last>Dalton</last>
          <ascii_first>Andy</ascii_first>
          <ascii_last>Dalton</ascii_last>
        </name>
        <editorial_player_key>nfl.p.24822</editorial_player_key>
        <editorial_team_key>nfl.t.4</editorial_team_key>
        <editorial_team_full_name>Cincinnati Bengals</editorial_team_full_name>
        <editorial_team_abbr>Cin</editorial_team_abbr>
        <bye_weeks>
          <week>8</week>
        </bye_weeks>
        <uniform_number>14</uniform_number>
        <display_position>QB</display_position>
        <headshot>
          <url>http://l.yimg.com/iu/api/res/1.2/2g42K0VEIydjI4.rG3ruEA--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/24822.jpg</url>
          <size>small</size>
        </headshot>
        <image_url>http://l.yimg.com/iu/api/res/1.2/2g42K0VEIydjI4.rG3ruEA--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/24822.jpg</image_url>
        <is_undroppable>0</is_undroppable>
        <position_type>O</position_type>
        <eligible_positions>
          <position>QB</position>
        </eligible_positions>
      </player>
      <player>
        <player_key>273.p.24823</player_key>
        <player_id>24823</player_id>
        <name>
          <full>Colin Kaepernick</full>
          <first>Colin</first>
          <last>Kaepernick</last>
          <ascii_first>Colin</ascii_first>
          <ascii_last>Kaepernick</ascii_last>
        </name>
        <editorial_player_key>nfl.p.24823</editorial_player_key>
        <editorial_team_key>nfl.t.25</editorial_team_key>
        <editorial_team_full_name>San Francisco 49ers</editorial_team_full_name>
        <editorial_team_abbr>SF</editorial_team_abbr>
        <bye_weeks>
          <week>9</week>
        </bye_weeks>
        <uniform_number>7</uniform_number>
        <display_position>QB</display_position>
        <headshot>
          <url>http://l.yimg.com/iu/api/res/1.2/KEXweY8c.a_RR7cjG_WeZA--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/24823.jpg</url>
          <size>small</size>
        </headshot>
        <image_url>http://l.yimg.com/iu/api/res/1.2/KEXweY8c.a_RR7cjG_WeZA--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/24823.jpg</image_url>
        <is_undroppable>0</is_undroppable>
        <position_type>O</position_type>
        <eligible_positions>
          <position>QB</position>
        </eligible_positions>
      </player>
      <player>
        <player_key>273.p.24860</player_key>
        <player_id>24860</player_id>
        <name>
          <full>Stevan Ridley</full>
          <first>Stevan</first>
          <last>Ridley</last>
          <ascii_first>Stevan</ascii_first>
          <ascii_last>Ridley</ascii_last>
        </name>
        <editorial_player_key>nfl.p.24860</editorial_player_key>
        <editorial_team_key>nfl.t.17</editorial_team_key>
        <editorial_team_full_name>New England Patriots</editorial_team_full_name>
        <editorial_team_abbr>NE</editorial_team_abbr>
        <bye_weeks>
          <week>9</week>
        </bye_weeks>
        <uniform_number>22</uniform_number>
        <display_position>RB</display_position>
        <headshot>
          <url>http://l.yimg.com/iu/api/res/1.2/4LBd.cKuNLu1ahmAvJ6Tsw--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/24860.jpg</url>
          <size>small</size>
        </headshot>
        <image_url>http://l.yimg.com/iu/api/res/1.2/4LBd.cKuNLu1ahmAvJ6Tsw--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/24860.jpg</image_url>
        <is_undroppable>0</is_undroppable>
        <position_type>O</position_type>
        <eligible_positions>
          <position>RB</position>
          <position>W/R</position>
        </eligible_positions>
      </player>
      <player>
        <player_key>273.p.25883</player_key>
        <player_id>25883</player_id>
        <name>
          <full>Alfred Morris</full>
          <first>Alfred</first>
          <last>Morris</last>
          <ascii_first>Alfred</ascii_first>
          <ascii_last>Morris</ascii_last>
        </name>
        <editorial_player_key>nfl.p.25883</editorial_player_key>
        <editorial_team_key>nfl.t.28</editorial_team_key>
        <editorial_team_full_name>Washington Redskins</editorial_team_full_name>
        <editorial_team_abbr>Was</editorial_team_abbr>
        <bye_weeks>
          <week>10</week>
        </bye_weeks>
        <uniform_number>46</uniform_number>
        <display_position>RB</display_position>
        <headshot>
          <url>http://l.yimg.com/iu/api/res/1.2/_1ktnIt.6JSR9Y4Raps8ow--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/25883.jpg</url>
          <size>small</size>
        </headshot>
        <image_url>http://l.yimg.com/iu/api/res/1.2/_1ktnIt.6JSR9Y4Raps8ow--/YXBwaWQ9eXZpZGVvO2NoPTg2MDtjcj0xO2N3PTY1OTtkeD0xO2R5PTE7Zmk9dWxjcm9wO2g9NjA7cT0xMDA7dz00Ng--/http://l.yimg.com/j/assets/i/us/sp/v/nfl/players_l/20120913/25883.jpg</image_url>
        <is_undroppable>1</is_undroppable>
        <position_type>O</position_type>
        <eligible_positions>
          <position>RB</position>
          <position>W/R</position>
        </eligible_positions>
      </player>
    </players>
  </team>
</fantasy_content>
*/