namespace PortfolioProject.Entities
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string SkillTitle { get; set; }
        public string Descrpition { get; set; }
        public string IconUrl { get; set; }
        public List<Skill> SkillList { get; set; }
    }
}