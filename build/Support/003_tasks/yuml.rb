require 'launchy'

task :generate do
  text = File.read_all_text('diagram')
  text = text.gsub("\n",',')
  Launchy.open("http://yuml.me/diagram/scruffy;/class/#{text}")
end

task :present do
  	`reveal-md presentation`
end

