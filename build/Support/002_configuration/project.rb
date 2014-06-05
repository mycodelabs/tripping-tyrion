config = 
{
  :project => "mars_rovers_project",
  :root_namespace => "mars_rovers_project",
  :target => "Debug",
  :source_dir =>"src",
  :all_references => UniqueFiles.new(Dir.glob("packages/**/*.{dll,exe}")).all_files,
  :artifacts_dir => "artifacts",
  :app_dir => "src/mars_rovers_project",
  :log_file_name => "#{configatron.project}_log.txt",
  :config_dir => "src/config",
  :log_level => "DEBUG",
  :deploy_dir => "deploy",
  :solution_file => "mars_rovers_project.sln",
  :release_dir => "artifacts/release"
}
configatron.configure_from_hash config