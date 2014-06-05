require 'rake'
require 'rake/clean'
require 'fileutils'
require 'erb'
require 'configatron'

Dir.glob("build/support/**/*.rb").each do|item|
  require File.expand_path(item)
end

 [configatron.artifacts_dir, configatron.specs.dir, configatron.release_dir].each do |item|
   CLEAN.include(item)
 end

Rake::Task['expand_all_template_files'].invoke

task :default => ["specs:run"]
task :deploy => ["deploy:clean", "cibuild:run", "deploy:install"]
task :localbuild => [ "init","deploy:clean", "cibuild:run"]

task :init  => :clean do
  [
    configatron.artifacts_dir,    
    configatron.specs.dir,
    configatron.specs.report_dir,
    configatron.release_dir
  ].each do |folder|
    if ! File.exists?(folder)
      FileUtils.mkdir_p folder
    end
  end
end
