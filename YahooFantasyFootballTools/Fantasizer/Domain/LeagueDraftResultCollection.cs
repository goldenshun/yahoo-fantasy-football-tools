﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Fantasizer.Domain
{
    public class LeagueDraftResultCollection
    {
        private LeagueDraftResultCollection(League league, DraftResultCollection draftResults)
        {
            if (league == null) { throw new ArgumentNullException("league"); }
            if (draftResults == null) { throw new ArgumentNullException("draftResults"); }
            
            this.League = league;
            this.DraftResults = draftResults;
        }

        public League League { get; private set; }
        public DraftResultCollection DraftResults { get; private set; }

        internal static LeagueDraftResultCollection CreateFromXml(XDocument xml)
        {
            var leagueElement = xml.Root.Element(YahooXml.XMLNS + "league");

            var league = League.CreateFromXml(leagueElement);
            var draftResults = DraftResultCollection.CreateFromXml(xml);

            return new LeagueDraftResultCollection(league, draftResults);
        }
    }
}

/*
<fantasy_content xml:lang="en-US" yahoo:uri="http://fantasysports.yahooapis.com/fantasy/v2/league/273.l.86177/draftresults" xmlns:yahoo="http://www.yahooapis.com/v1/base.rng" time="62.987089157104ms" copyright="Data provided by Yahoo! and STATS, LLC" refresh_rate="60" xmlns="http://fantasysports.yahooapis.com/fantasy/v2/base.rng">
  <league>
    <league_key>273.l.86177</league_key>
    <league_id>86177</league_id>
    <name>Let the Wookie Win</name>
    <url>http://football.fantasysports.yahoo.com/archive/nfl/2012/86177</url>
    <draft_status>postdraft</draft_status>
    <num_teams>10</num_teams>
    <edit_key>17</edit_key>
    <weekly_deadline />
    <league_update_timestamp>1357340032</league_update_timestamp>
    <scoring_type>head</scoring_type>
    <league_type>private</league_type>
    <is_pro_league>0</is_pro_league>
    <current_week>16</current_week>
    <start_week>1</start_week>
    <start_date>2012-09-05</start_date>
    <end_week>16</end_week>
    <end_date>2012-12-24</end_date>
    <is_finished>1</is_finished>
    <draft_results count="150">
      <draft_result>
        <pick>1</pick>
        <round>1</round>
        <team_key>273.l.86177.t.3</team_key>
        <player_key>273.p.8832</player_key>
      </draft_result>
      <draft_result>
        <pick>2</pick>
        <round>1</round>
        <team_key>273.l.86177.t.4</team_key>
        <player_key>273.p.9317</player_key>
      </draft_result>
      <draft_result>
        <pick>3</pick>
        <round>1</round>
        <team_key>273.l.86177.t.6</team_key>
        <player_key>273.p.7200</player_key>
      </draft_result>
      <draft_result>
        <pick>4</pick>
        <round>1</round>
        <team_key>273.l.86177.t.2</team_key>
        <player_key>273.p.8821</player_key>
      </draft_result>
      <draft_result>
        <pick>5</pick>
        <round>1</round>
        <team_key>273.l.86177.t.9</team_key>
        <player_key>273.p.9527</player_key>
      </draft_result>
      <draft_result>
        <pick>6</pick>
        <round>1</round>
        <team_key>273.l.86177.t.1</team_key>
        <player_key>273.p.8801</player_key>
      </draft_result>
      <draft_result>
        <pick>7</pick>
        <round>1</round>
        <team_key>273.l.86177.t.8</team_key>
        <player_key>273.p.5479</player_key>
      </draft_result>
      <draft_result>
        <pick>8</pick>
        <round>1</round>
        <team_key>273.l.86177.t.7</team_key>
        <player_key>273.p.8781</player_key>
      </draft_result>
      <draft_result>
        <pick>9</pick>
        <round>1</round>
        <team_key>273.l.86177.t.5</team_key>
        <player_key>273.p.8256</player_key>
      </draft_result>
      <draft_result>
        <pick>10</pick>
        <round>1</round>
        <team_key>273.l.86177.t.10</team_key>
        <player_key>273.p.7809</player_key>
      </draft_result>
      <draft_result>
        <pick>11</pick>
        <round>2</round>
        <team_key>273.l.86177.t.10</team_key>
        <player_key>273.p.7027</player_key>
      </draft_result>
      <draft_result>
        <pick>12</pick>
        <round>2</round>
        <team_key>273.l.86177.t.5</team_key>
        <player_key>273.p.8261</player_key>
      </draft_result>
      <draft_result>
        <pick>13</pick>
        <round>2</round>
        <team_key>273.l.86177.t.7</team_key>
        <player_key>273.p.6762</player_key>
      </draft_result>
      <draft_result>
        <pick>14</pick>
        <round>2</round>
        <team_key>273.l.86177.t.8</team_key>
        <player_key>273.p.24858</player_key>
      </draft_result>
      <draft_result>
        <pick>15</pick>
        <round>2</round>
        <team_key>273.l.86177.t.1</team_key>
        <player_key>273.p.24793</player_key>
      </draft_result>
      <draft_result>
        <pick>16</pick>
        <round>2</round>
        <team_key>273.l.86177.t.9</team_key>
        <player_key>273.p.25713</player_key>
      </draft_result>
      <draft_result>
        <pick>17</pick>
        <round>2</round>
        <team_key>273.l.86177.t.2</team_key>
        <player_key>273.p.7801</player_key>
      </draft_result>
      <draft_result>
        <pick>18</pick>
        <round>2</round>
        <team_key>273.l.86177.t.6</team_key>
        <player_key>273.p.7868</player_key>
      </draft_result>
      <draft_result>
        <pick>19</pick>
        <round>2</round>
        <team_key>273.l.86177.t.4</team_key>
        <player_key>273.p.24791</player_key>
      </draft_result>
      <draft_result>
        <pick>20</pick>
        <round>2</round>
        <team_key>273.l.86177.t.3</team_key>
        <player_key>273.p.5448</player_key>
      </draft_result>
      <draft_result>
        <pick>21</pick>
        <round>3</round>
        <team_key>273.l.86177.t.3</team_key>
        <player_key>273.p.7203</player_key>
      </draft_result>
      <draft_result>
        <pick>22</pick>
        <round>3</round>
        <team_key>273.l.86177.t.4</team_key>
        <player_key>273.p.6783</player_key>
      </draft_result>
      <draft_result>
        <pick>23</pick>
        <round>3</round>
        <team_key>273.l.86177.t.6</team_key>
        <player_key>273.p.8850</player_key>
      </draft_result>
      <draft_result>
        <pick>24</pick>
        <round>3</round>
        <team_key>273.l.86177.t.2</team_key>
        <player_key>273.p.5521</player_key>
      </draft_result>
      <draft_result>
        <pick>25</pick>
        <round>3</round>
        <team_key>273.l.86177.t.9</team_key>
        <player_key>273.p.23987</player_key>
      </draft_result>
      <draft_result>
        <pick>26</pick>
        <round>3</round>
        <team_key>273.l.86177.t.1</team_key>
        <player_key>273.p.8063</player_key>
      </draft_result>
      <draft_result>
        <pick>27</pick>
        <round>3</round>
        <team_key>273.l.86177.t.8</team_key>
        <player_key>273.p.6339</player_key>
      </draft_result>
      <draft_result>
        <pick>28</pick>
        <round>3</round>
        <team_key>273.l.86177.t.7</team_key>
        <player_key>273.p.7306</player_key>
      </draft_result>
      <draft_result>
        <pick>29</pick>
        <round>3</round>
        <team_key>273.l.86177.t.5</team_key>
        <player_key>273.p.9293</player_key>
      </draft_result>
      <draft_result>
        <pick>30</pick>
        <round>3</round>
        <team_key>273.l.86177.t.10</team_key>
        <player_key>273.p.4256</player_key>
      </draft_result>
      <draft_result>
        <pick>31</pick>
        <round>4</round>
        <team_key>273.l.86177.t.10</team_key>
        <player_key>273.p.6913</player_key>
      </draft_result>
      <draft_result>
        <pick>32</pick>
        <round>4</round>
        <team_key>273.l.86177.t.5</team_key>
        <player_key>273.p.7241</player_key>
      </draft_result>
      <draft_result>
        <pick>33</pick>
        <round>4</round>
        <team_key>273.l.86177.t.7</team_key>
        <player_key>273.p.23999</player_key>
      </draft_result>
      <draft_result>
        <pick>34</pick>
        <round>4</round>
        <team_key>273.l.86177.t.8</team_key>
        <player_key>273.p.8266</player_key>
      </draft_result>
      <draft_result>
        <pick>35</pick>
        <round>4</round>
        <team_key>273.l.86177.t.1</team_key>
        <player_key>273.p.8813</player_key>
      </draft_result>
      <draft_result>
        <pick>36</pick>
        <round>4</round>
        <team_key>273.l.86177.t.9</team_key>
        <player_key>273.p.9348</player_key>
      </draft_result>
      <draft_result>
        <pick>37</pick>
        <round>4</round>
        <team_key>273.l.86177.t.2</team_key>
        <player_key>273.p.5228</player_key>
      </draft_result>
      <draft_result>
        <pick>38</pick>
        <round>4</round>
        <team_key>273.l.86177.t.6</team_key>
        <player_key>273.p.25741</player_key>
      </draft_result>
      <draft_result>
        <pick>39</pick>
        <round>4</round>
        <team_key>273.l.86177.t.4</team_key>
        <player_key>273.p.8001</player_key>
      </draft_result>
      <draft_result>
        <pick>40</pick>
        <round>4</round>
        <team_key>273.l.86177.t.3</team_key>
        <player_key>273.p.7751</player_key>
      </draft_result>
      <draft_result>
        <pick>41</pick>
        <round>5</round>
        <team_key>273.l.86177.t.3</team_key>
        <player_key>273.p.9286</player_key>
      </draft_result>
      <draft_result>
        <pick>42</pick>
        <round>5</round>
        <team_key>273.l.86177.t.4</team_key>
        <player_key>273.p.8504</player_key>
      </draft_result>
      <draft_result>
        <pick>43</pick>
        <round>5</round>
        <team_key>273.l.86177.t.6</team_key>
        <player_key>273.p.6460</player_key>
      </draft_result>
      <draft_result>
        <pick>44</pick>
        <round>5</round>
        <team_key>273.l.86177.t.2</team_key>
        <player_key>273.p.6663</player_key>
      </draft_result>
      <draft_result>
        <pick>45</pick>
        <round>5</round>
        <team_key>273.l.86177.t.9</team_key>
        <player_key>273.p.6760</player_key>
      </draft_result>
      <draft_result>
        <pick>46</pick>
        <round>5</round>
        <team_key>273.l.86177.t.1</team_key>
        <player_key>273.p.24088</player_key>
      </draft_result>
      <draft_result>
        <pick>47</pick>
        <round>5</round>
        <team_key>273.l.86177.t.8</team_key>
        <player_key>273.p.9283</player_key>
      </draft_result>
      <draft_result>
        <pick>48</pick>
        <round>5</round>
        <team_key>273.l.86177.t.7</team_key>
        <player_key>273.p.8021</player_key>
      </draft_result>
      <draft_result>
        <pick>49</pick>
        <round>5</round>
        <team_key>273.l.86177.t.5</team_key>
        <player_key>273.p.7755</player_key>
      </draft_result>
      <draft_result>
        <pick>50</pick>
        <round>5</round>
        <team_key>273.l.86177.t.10</team_key>
        <player_key>273.p.8825</player_key>
      </draft_result>
      <draft_result>
        <pick>51</pick>
        <round>6</round>
        <team_key>273.l.86177.t.10</team_key>
        <player_key>273.p.8826</player_key>
      </draft_result>
      <draft_result>
        <pick>52</pick>
        <round>6</round>
        <team_key>273.l.86177.t.5</team_key>
        <player_key>273.p.24171</player_key>
      </draft_result>
      <draft_result>
        <pick>53</pick>
        <round>6</round>
        <team_key>273.l.86177.t.7</team_key>
        <player_key>273.p.7237</player_key>
      </draft_result>
      <draft_result>
        <pick>54</pick>
        <round>6</round>
        <team_key>273.l.86177.t.8</team_key>
        <player_key>273.p.8277</player_key>
      </draft_result>
      <draft_result>
        <pick>55</pick>
        <round>6</round>
        <team_key>273.l.86177.t.1</team_key>
        <player_key>273.p.9001</player_key>
      </draft_result>
      <draft_result>
        <pick>56</pick>
        <round>6</round>
        <team_key>273.l.86177.t.9</team_key>
        <player_key>273.p.8868</player_key>
      </draft_result>
      <draft_result>
        <pick>57</pick>
        <round>6</round>
        <team_key>273.l.86177.t.2</team_key>
        <player_key>273.p.9329</player_key>
      </draft_result>
      <draft_result>
        <pick>58</pick>
        <round>6</round>
        <team_key>273.l.86177.t.6</team_key>
        <player_key>273.p.9284</player_key>
      </draft_result>
      <draft_result>
        <pick>59</pick>
        <round>6</round>
        <team_key>273.l.86177.t.4</team_key>
        <player_key>273.p.6624</player_key>
      </draft_result>
      <draft_result>
        <pick>60</pick>
        <round>6</round>
        <team_key>273.l.86177.t.3</team_key>
        <player_key>273.p.24017</player_key>
      </draft_result>
      <draft_result>
        <pick>61</pick>
        <round>7</round>
        <team_key>273.l.86177.t.3</team_key>
        <player_key>273.p.9039</player_key>
      </draft_result>
      <draft_result>
        <pick>62</pick>
        <round>7</round>
        <team_key>273.l.86177.t.4</team_key>
        <player_key>273.p.24892</player_key>
      </draft_result>
      <draft_result>
        <pick>63</pick>
        <round>7</round>
        <team_key>273.l.86177.t.6</team_key>
        <player_key>273.p.9291</player_key>
      </draft_result>
      <draft_result>
        <pick>64</pick>
        <round>7</round>
        <team_key>273.l.86177.t.2</team_key>
        <player_key>273.p.24845</player_key>
      </draft_result>
      <draft_result>
        <pick>65</pick>
        <round>7</round>
        <team_key>273.l.86177.t.9</team_key>
        <player_key>273.p.8281</player_key>
      </draft_result>
      <draft_result>
        <pick>66</pick>
        <round>7</round>
        <team_key>273.l.86177.t.1</team_key>
        <player_key>273.p.6359</player_key>
      </draft_result>
      <draft_result>
        <pick>67</pick>
        <round>7</round>
        <team_key>273.l.86177.t.8</team_key>
        <player_key>273.p.24070</player_key>
      </draft_result>
      <draft_result>
        <pick>68</pick>
        <round>7</round>
        <team_key>273.l.86177.t.7</team_key>
        <player_key>273.p.9295</player_key>
      </draft_result>
      <draft_result>
        <pick>69</pick>
        <round>7</round>
        <team_key>273.l.86177.t.5</team_key>
        <player_key>273.p.8790</player_key>
      </draft_result>
      <draft_result>
        <pick>70</pick>
        <round>7</round>
        <team_key>273.l.86177.t.10</team_key>
        <player_key>273.p.8298</player_key>
      </draft_result>
      <draft_result>
        <pick>71</pick>
        <round>8</round>
        <team_key>273.l.86177.t.10</team_key>
        <player_key>273.p.8780</player_key>
      </draft_result>
      <draft_result>
        <pick>72</pick>
        <round>8</round>
        <team_key>273.l.86177.t.5</team_key>
        <player_key>273.p.6763</player_key>
      </draft_result>
      <draft_result>
        <pick>73</pick>
        <round>8</round>
        <team_key>273.l.86177.t.7</team_key>
        <player_key>273.p.5477</player_key>
      </draft_result>
      <draft_result>
        <pick>74</pick>
        <round>8</round>
        <team_key>273.l.86177.t.8</team_key>
        <player_key>273.p.9674</player_key>
      </draft_result>
      <draft_result>
        <pick>75</pick>
        <round>8</round>
        <team_key>273.l.86177.t.1</team_key>
        <player_key>273.p.9004</player_key>
      </draft_result>
      <draft_result>
        <pick>76</pick>
        <round>8</round>
        <team_key>273.l.86177.t.9</team_key>
        <player_key>273.p.9294</player_key>
      </draft_result>
      <draft_result>
        <pick>77</pick>
        <round>8</round>
        <team_key>273.l.86177.t.2</team_key>
        <player_key>273.p.24005</player_key>
      </draft_result>
      <draft_result>
        <pick>78</pick>
        <round>8</round>
        <team_key>273.l.86177.t.6</team_key>
        <player_key>273.p.8982</player_key>
      </draft_result>
      <draft_result>
        <pick>79</pick>
        <round>8</round>
        <team_key>273.l.86177.t.4</team_key>
        <player_key>273.p.6405</player_key>
      </draft_result>
      <draft_result>
        <pick>80</pick>
        <round>8</round>
        <team_key>273.l.86177.t.3</team_key>
        <player_key>273.p.24076</player_key>
      </draft_result>
      <draft_result>
        <pick>81</pick>
        <round>9</round>
        <team_key>273.l.86177.t.3</team_key>
        <player_key>273.p.8354</player_key>
      </draft_result>
      <draft_result>
        <pick>82</pick>
        <round>9</round>
        <team_key>273.l.86177.t.4</team_key>
        <player_key>273.p.25715</player_key>
      </draft_result>
      <draft_result>
        <pick>83</pick>
        <round>9</round>
        <team_key>273.l.86177.t.6</team_key>
        <player_key>273.p.7149</player_key>
      </draft_result>
      <draft_result>
        <pick>84</pick>
        <round>9</round>
        <team_key>273.l.86177.t.2</team_key>
        <player_key>273.p.24815</player_key>
      </draft_result>
      <draft_result>
        <pick>85</pick>
        <round>9</round>
        <team_key>273.l.86177.t.9</team_key>
        <player_key>273.p.23984</player_key>
      </draft_result>
      <draft_result>
        <pick>86</pick>
        <round>9</round>
        <team_key>273.l.86177.t.1</team_key>
        <player_key>273.p.9271</player_key>
      </draft_result>
      <draft_result>
        <pick>87</pick>
        <round>9</round>
        <team_key>273.l.86177.t.8</team_key>
        <player_key>273.p.7774</player_key>
      </draft_result>
      <draft_result>
        <pick>88</pick>
        <round>9</round>
        <team_key>273.l.86177.t.7</team_key>
        <player_key>273.p.3950</player_key>
      </draft_result>
      <draft_result>
        <pick>89</pick>
        <round>9</round>
        <team_key>273.l.86177.t.5</team_key>
        <player_key>273.p.7776</player_key>
      </draft_result>
      <draft_result>
        <pick>90</pick>
        <round>9</round>
        <team_key>273.l.86177.t.10</team_key>
        <player_key>273.p.9274</player_key>
      </draft_result>
      <draft_result>
        <pick>91</pick>
        <round>10</round>
        <team_key>273.l.86177.t.10</team_key>
        <player_key>273.p.24843</player_key>
      </draft_result>
      <draft_result>
        <pick>92</pick>
        <round>10</round>
        <team_key>273.l.86177.t.5</team_key>
        <player_key>273.p.7492</player_key>
      </draft_result>
      <draft_result>
        <pick>93</pick>
        <round>10</round>
        <team_key>273.l.86177.t.7</team_key>
        <player_key>273.p.24932</player_key>
      </draft_result>
      <draft_result>
        <pick>94</pick>
        <round>10</round>
        <team_key>273.l.86177.t.8</team_key>
        <player_key>273.p.25742</player_key>
      </draft_result>
      <draft_result>
        <pick>95</pick>
        <round>10</round>
        <team_key>273.l.86177.t.1</team_key>
        <player_key>273.p.24935</player_key>
      </draft_result>
      <draft_result>
        <pick>96</pick>
        <round>10</round>
        <team_key>273.l.86177.t.9</team_key>
        <player_key>273.p.25712</player_key>
      </draft_result>
      <draft_result>
        <pick>97</pick>
        <round>10</round>
        <team_key>273.l.86177.t.2</team_key>
        <player_key>273.p.24825</player_key>
      </draft_result>
      <draft_result>
        <pick>98</pick>
        <round>10</round>
        <team_key>273.l.86177.t.6</team_key>
        <player_key>273.p.7760</player_key>
      </draft_result>
      <draft_result>
        <pick>99</pick>
        <round>10</round>
        <team_key>273.l.86177.t.4</team_key>
        <player_key>273.p.24860</player_key>
      </draft_result>
      <draft_result>
        <pick>100</pick>
        <round>10</round>
        <team_key>273.l.86177.t.3</team_key>
        <player_key>273.p.9043</player_key>
      </draft_result>
      <draft_result>
        <pick>101</pick>
        <round>11</round>
        <team_key>273.l.86177.t.3</team_key>
        <player_key>273.p.7867</player_key>
      </draft_result>
      <draft_result>
        <pick>102</pick>
        <round>11</round>
        <team_key>273.l.86177.t.4</team_key>
        <player_key>273.p.24846</player_key>
      </draft_result>
      <draft_result>
        <pick>103</pick>
        <round>11</round>
        <team_key>273.l.86177.t.6</team_key>
        <player_key>273.p.24164</player_key>
      </draft_result>
      <draft_result>
        <pick>104</pick>
        <round>11</round>
        <team_key>273.l.86177.t.2</team_key>
        <player_key>273.p.100025</player_key>
      </draft_result>
      <draft_result>
        <pick>105</pick>
        <round>11</round>
        <team_key>273.l.86177.t.9</team_key>
        <player_key>273.p.4262</player_key>
      </draft_result>
      <draft_result>
        <pick>106</pick>
        <round>11</round>
        <team_key>273.l.86177.t.1</team_key>
        <player_key>273.p.24033</player_key>
      </draft_result>
      <draft_result>
        <pick>107</pick>
        <round>11</round>
        <team_key>273.l.86177.t.8</team_key>
        <player_key>273.p.24026</player_key>
      </draft_result>
      <draft_result>
        <pick>108</pick>
        <round>11</round>
        <team_key>273.l.86177.t.7</team_key>
        <player_key>273.p.9265</player_key>
      </draft_result>
      <draft_result>
        <pick>109</pick>
        <round>11</round>
        <team_key>273.l.86177.t.5</team_key>
        <player_key>273.p.100033</player_key>
      </draft_result>
      <draft_result>
        <pick>110</pick>
        <round>11</round>
        <team_key>273.l.86177.t.10</team_key>
        <player_key>273.p.24169</player_key>
      </draft_result>
      <draft_result>
        <pick>111</pick>
        <round>12</round>
        <team_key>273.l.86177.t.10</team_key>
        <player_key>273.p.5463</player_key>
      </draft_result>
      <draft_result>
        <pick>112</pick>
        <round>12</round>
        <team_key>273.l.86177.t.5</team_key>
        <player_key>273.p.8329</player_key>
      </draft_result>
      <draft_result>
        <pick>113</pick>
        <round>12</round>
        <team_key>273.l.86177.t.7</team_key>
        <player_key>273.p.24869</player_key>
      </draft_result>
      <draft_result>
        <pick>114</pick>
        <round>12</round>
        <team_key>273.l.86177.t.8</team_key>
        <player_key>273.p.4587</player_key>
      </draft_result>
      <draft_result>
        <pick>115</pick>
        <round>12</round>
        <team_key>273.l.86177.t.1</team_key>
        <player_key>273.p.25711</player_key>
      </draft_result>
      <draft_result>
        <pick>116</pick>
        <round>12</round>
        <team_key>273.l.86177.t.9</team_key>
        <player_key>273.p.100003</player_key>
      </draft_result>
      <draft_result>
        <pick>117</pick>
        <round>12</round>
        <team_key>273.l.86177.t.2</team_key>
        <player_key>273.p.25777</player_key>
      </draft_result>
      <draft_result>
        <pick>118</pick>
        <round>12</round>
        <team_key>273.l.86177.t.6</team_key>
        <player_key>273.p.8416</player_key>
      </draft_result>
      <draft_result>
        <pick>119</pick>
        <round>12</round>
        <team_key>273.l.86177.t.4</team_key>
        <player_key>273.p.23996</player_key>
      </draft_result>
      <draft_result>
        <pick>120</pick>
        <round>12</round>
        <team_key>273.l.86177.t.3</team_key>
        <player_key>273.p.100023</player_key>
      </draft_result>
      <draft_result>
        <pick>121</pick>
        <round>13</round>
        <team_key>273.l.86177.t.3</team_key>
        <player_key>273.p.7544</player_key>
      </draft_result>
      <draft_result>
        <pick>122</pick>
        <round>13</round>
        <team_key>273.l.86177.t.4</team_key>
        <player_key>273.p.100009</player_key>
      </draft_result>
      <draft_result>
        <pick>123</pick>
        <round>13</round>
        <team_key>273.l.86177.t.6</team_key>
        <player_key>273.p.100021</player_key>
      </draft_result>
      <draft_result>
        <pick>124</pick>
        <round>13</round>
        <team_key>273.l.86177.t.2</team_key>
        <player_key>273.p.25723</player_key>
      </draft_result>
      <draft_result>
        <pick>125</pick>
        <round>13</round>
        <team_key>273.l.86177.t.9</team_key>
        <player_key>273.p.6390</player_key>
      </draft_result>
      <draft_result>
        <pick>126</pick>
        <round>13</round>
        <team_key>273.l.86177.t.1</team_key>
        <player_key>273.p.100034</player_key>
      </draft_result>
      <draft_result>
        <pick>127</pick>
        <round>13</round>
        <team_key>273.l.86177.t.8</team_key>
        <player_key>273.p.6770</player_key>
      </draft_result>
      <draft_result>
        <pick>128</pick>
        <round>13</round>
        <team_key>273.l.86177.t.7</team_key>
        <player_key>273.p.100008</player_key>
      </draft_result>
      <draft_result>
        <pick>129</pick>
        <round>13</round>
        <team_key>273.l.86177.t.5</team_key>
        <player_key>273.p.7180</player_key>
      </draft_result>
      <draft_result>
        <pick>130</pick>
        <round>13</round>
        <team_key>273.l.86177.t.10</team_key>
        <player_key>273.p.8447</player_key>
      </draft_result>
      <draft_result>
        <pick>131</pick>
        <round>14</round>
        <team_key>273.l.86177.t.10</team_key>
        <player_key>273.p.100026</player_key>
      </draft_result>
      <draft_result>
        <pick>132</pick>
        <round>14</round>
        <team_key>273.l.86177.t.5</team_key>
        <player_key>273.p.5046</player_key>
      </draft_result>
      <draft_result>
        <pick>133</pick>
        <round>14</round>
        <team_key>273.l.86177.t.7</team_key>
        <player_key>273.p.25427</player_key>
      </draft_result>
      <draft_result>
        <pick>134</pick>
        <round>14</round>
        <team_key>273.l.86177.t.8</team_key>
        <player_key>273.p.100017</player_key>
      </draft_result>
      <draft_result>
        <pick>135</pick>
        <round>14</round>
        <team_key>273.l.86177.t.1</team_key>
        <player_key>273.p.9222</player_key>
      </draft_result>
      <draft_result>
        <pick>136</pick>
        <round>14</round>
        <team_key>273.l.86177.t.9</team_key>
        <player_key>273.p.1111</player_key>
      </draft_result>
      <draft_result>
        <pick>137</pick>
        <round>14</round>
        <team_key>273.l.86177.t.2</team_key>
        <player_key>273.p.100022</player_key>
      </draft_result>
      <draft_result>
        <pick>138</pick>
        <round>14</round>
        <team_key>273.l.86177.t.6</team_key>
        <player_key>273.p.24907</player_key>
      </draft_result>
      <draft_result>
        <pick>139</pick>
        <round>14</round>
        <team_key>273.l.86177.t.4</team_key>
        <player_key>273.p.6243</player_key>
      </draft_result>
      <draft_result>
        <pick>140</pick>
        <round>14</round>
        <team_key>273.l.86177.t.3</team_key>
        <player_key>273.p.6849</player_key>
      </draft_result>
      <draft_result>
        <pick>141</pick>
        <round>15</round>
        <team_key>273.l.86177.t.3</team_key>
        <player_key>273.p.6407</player_key>
      </draft_result>
      <draft_result>
        <pick>142</pick>
        <round>15</round>
        <team_key>273.l.86177.t.4</team_key>
        <player_key>273.p.23997</player_key>
      </draft_result>
      <draft_result>
        <pick>143</pick>
        <round>15</round>
        <team_key>273.l.86177.t.6</team_key>
        <player_key>273.p.24062</player_key>
      </draft_result>
      <draft_result>
        <pick>144</pick>
        <round>15</round>
        <team_key>273.l.86177.t.2</team_key>
        <player_key>273.p.2034</player_key>
      </draft_result>
      <draft_result>
        <pick>145</pick>
        <round>15</round>
        <team_key>273.l.86177.t.9</team_key>
        <player_key>273.p.8916</player_key>
      </draft_result>
      <draft_result>
        <pick>146</pick>
        <round>15</round>
        <team_key>273.l.86177.t.1</team_key>
        <player_key>273.p.24788</player_key>
      </draft_result>
      <draft_result>
        <pick>147</pick>
        <round>15</round>
        <team_key>273.l.86177.t.8</team_key>
        <player_key>273.p.24831</player_key>
      </draft_result>
      <draft_result>
        <pick>148</pick>
        <round>15</round>
        <team_key>273.l.86177.t.7</team_key>
        <player_key>273.p.9514</player_key>
      </draft_result>
      <draft_result>
        <pick>149</pick>
        <round>15</round>
        <team_key>273.l.86177.t.5</team_key>
        <player_key>273.p.24844</player_key>
      </draft_result>
      <draft_result>
        <pick>150</pick>
        <round>15</round>
        <team_key>273.l.86177.t.10</team_key>
        <player_key>273.p.24553</player_key>
      </draft_result>
    </draft_results>
  </league>
</fantasy_content>
*/